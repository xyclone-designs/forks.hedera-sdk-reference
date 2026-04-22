using Hedera.Hashgraph.Reference.Cryptocurrency;

using System;

namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// The client-generated ID for a transaction.
    /// </summary>
    public interface ITransactionId
    {
        /// <summary>
        /// Serialize the transaction into protobuf encoded bytes
        /// </summary>
        byte[] ToBytes();
        /// <summary>
        /// Stringify the transaction ID
        /// </summary>
        string ToString();
        /// <summary>
        /// Convert to a string representation with checksum
        /// </summary>
        string ToStringWithChecksum(IClient client);

        /// <summary>
        /// The account ID of the transaction ID
        ///
        /// This account pays for the transaction
        /// </summary>
        public IAccountId AccountId { get; }
        /// <summary>
        /// The identifier for an internal transaction that was spawned as part of handling a user transaction.
        /// (These internal transactions share the transactionValidStart and accountID of the user transaction,
        /// so a nonce is necessary to give them a unique TransactionID.)
        ///
        /// An example is when a "parent" ContractCreate or ContractCall transaction calls one or more HTS
        /// precompiled contracts; each of the "child" transactions spawned for a precompiled contracts has an id with a
        /// different nonce.
        /// </summary>
        public long Nonce { get; }
        /// <summary>
        /// The scheduled status of the transaction
        /// </summary>
        public bool Scheduled { get; }
        /// <summary>
        /// The timestamp of this transaction
        ///
        /// Each transaction ID must have a unique timestamp. DateTimeOffset generation in the SDK fuzzes the current
        /// time so collisions are less likely
        /// </summary>
        public DateTimeOffset ValidStart { get; }
    }
    public interface ITransactionId<TSelf> : ITransactionId where TSelf : ITransactionId<TSelf>
    {
        /// <summary>
        /// Construct the transaction ID from a protobuf encoded `TransactionID`
        /// </summary>
        abstract static ITransactionId FromBytes(byte[] data);
        /// <summary>
        /// Construct a transaction ID from string
        ///
        /// **NOTE**: The transaction ID format is
        /// `(?<accountId>(\d+.\d+)?\d+)\.(?<timestamp>\d+.\d+)(?<scheduled>\?scheduled)?(?<nonce>/\d+)?`
        /// </summary>
        abstract static ITransactionId FromString(string text);
        /// <summary>
        /// Generate a transaction ID with the given account ID and a generated timestamp
        /// </summary>
        abstract static ITransactionId Generate(IAccountId accountId);
        /// <summary>
        /// Fetch the receipt of the transaction.
        /// </summary>
        abstract static ITransactionReceipt GetReceipt(IClient client);
        /// <summary>
        /// Fetch the record of the transaction.
        /// </summary>
        abstract static ITransactionRecord GetRecord(IClient client);
        /// <summary>
        /// Create a transaction id.
        /// </summary>
        abstract static ITransactionId WithValidStart(IAccountId accountId, DateTimeOffset validStart);
    }
}
