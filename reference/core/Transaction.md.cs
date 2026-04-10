using Hedera.Hashgraph.Reference.Cryptocurrency;

using System;
using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// Base class for all transactions that may be submitted to Hedera.
    /// </summary>
    public interface ITransaction
    {
        /// <summary>
        /// Construct a transaction from bytes
        ///
        /// **NOTE**: The bytes can be a protobuf encoded `TransactionBody`, `Transaction`, `SignedTransaction`
        /// or `TransactionList`
        /// </summary>
        public static Transaction FromBytes(byte[] data);

        /// <summary>
        /// Add a signature to the transaction
        ///
        /// **NOTE**: Requires the transaction to have a single node account ID set
        /// </summary>
        ITransaction AddSignature(IPublicKey key, byte[] signature);

        /// <summary>
        /// Execute this transaction on the Hedera network, immediately returning
        /// metadata about the transaction that was executed.
        /// The [`TransactionResponse`](TransactionResponse.md) may be used to fetch
        /// the [`TransactionReceipt`](TransactionReceipt.md) or
        /// [`TransactionRecord`](TransactionRecord.md)
        /// for more information.
        /// </summary>
        ITransactionResponse Execute(IClient client);

        /// <summary>
        /// Freeze the transaction getting it ready to be signed or executed.
        ///
        /// Freezing without a client requires a transaction ID and node account IDs to be manually set
        ///
        /// **NOTE**: Freezing the transaction means it cannot be modified anymore, so make sure to set all the
        /// fields correctly before freezing.
        ///
        /// **NOTE**: Freezing is required for certain operations such as signing and generating hash.
        /// </summary>
        ITransaction Freeze();

        /// <summary>
        /// Freeze the transaction with a client.
        ///
        /// The client's operator will be used to generate a transaction ID, and the client's network will be
        /// used to generate a list of node account IDs
        /// </summary>
        ITransaction FreezeWith(IClient client);

        /// <summary>
        /// Get the transaction signatures
        /// </summary>
        IDictionary<AccountId, IDictionary<IPublicKey, byte[]>> GetSignatures();

        /// <summary>
        /// Generate the SHA-384 hash of the transaction
        ///
        /// **NOTE**: Requires a single node account ID to be set on the transaction.
        /// Use `getTransactionHashPerNode()` when node account IDs were not manually set or were set to multiple
        /// values
        /// </summary>
        byte[] GetTransactionHash();

        /// <summary>
        /// Generate the SHA-384 hash of the transaction per node account ID
        ///
        /// The key for the returned map is the node account ID
        /// </summary>
        AccountId GetTransactionHashPerNode();

        /// <summary>
        /// Convert the transaction into a scheduled version
        /// </summary>
        IScheduleCreateTransaction Schedule();

        /// <summary>
        /// Sign the transaction with the given private key.
        ///
        /// **NOTE**:Signing with the same private key will be ignored.
        /// </summary>
        ITransaction Sign(IPrivateKey key);

        /// <summary>
        /// Sign the transaction with a public key and a signing callback.
        ///
        /// **NOTE**:Signing with the same public key will be ignored.
        /// </summary>
        ITransaction SignWith(IPublicKey publicKey, Func<byte[], byte[]> transactionSigner);

        /// <summary>
        /// Sign with the client's operator
        ///
        /// **NOTE**: If the operator has already signed this will be ignored
        /// </summary>
        ITransaction SignWithOperator(IClient client);

        /// <summary>
        /// Encodes this transaction to a byte array that can be later decoded into
        /// the same `Transaction`
        /// </summary>
        byte[] ToBytes();

        /// <summary>
        /// Тhe maximum transaction fee the client is willing to pay
        ///
        /// This value is set by the SDK
        /// </summary>
        Hbar DefaultMaxTransactionFee { get; }

        /// <summary>
        /// The number of times to retry submitting this transaction. Transactions are retried when Hedera
        /// Hashgraph returns a status code that implies the transaction should be resubmitted, or when a node
        /// doesn't respond.
        /// </summary>
        long MaxAttempts { get; }

        /// <summary>
        /// The maximum amount of time to wait between retries
        /// </summary>
        TimeSpan MaxBackoff { get; }

        /// <summary>
        /// The maximum transaction fee the client is willing to pay.
        ///
        /// Defaults to `maxTransactionFee` from the `client`.
        /// </summary>
        Hbar MaxTransactionFee { get; }

        /// <summary>
        /// The minimum amount of time to wait between retries
        /// </summary>
        TimeSpan MinBackoff { get; }

        /// <summary>
        /// The list of node account IDs that this transaction will be submitted to.
        ///
        /// Providing an explicit set of node account IDs interferes with client-side load balancing of the
        /// network. By default, the SDK will pre-generate a transaction for 1/3 of the nodes on the network. If
        /// a node is down, busy, or otherwise reports a fatal error, the SDK will try again with a different
        /// node.
        /// </summary>
        AccountId[] NodeAccountIds { get; }

        /// <summary>
        /// Declares if we should generate new transaction IDs when a transaction fails with
        /// `TRANSACTION_EXPIRED`
        ///
        /// **NOTE**: Defaults to `true`
        ///
        /// **NOTE**: If transaction IDs are locked, this option is ignored. Transaction IDs can be
        /// locked if set manually or if certain methods are called.
        /// </summary>
        bool RegenerateTransactionId { get; }

        /// <summary>
        /// The ID for this transaction, which includes the payer's account (the account paying the transaction
        /// fee).
        ///
        /// If two transactions have the same transactionID, they won't both have an effect
        /// </summary>
        TransactionId TransactionId { get; }

        /// <summary>
        /// Any notes or descriptions that should be put into the record (max length 100).
        /// </summary>
        string TransactionMemo { get; }

        /// <summary>
        /// TimeSpan from the valid start (within the transaction ID) that this
        /// transaction is valid for.
        ///
        /// **NOTE**: Defaults to 120 seconds.
        /// </summary>
        TimeSpan TransactionValidTimeSpan { get; }
    }
}
