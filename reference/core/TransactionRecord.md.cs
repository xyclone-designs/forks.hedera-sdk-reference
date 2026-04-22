using Hedera.Hashgraph.Reference.Contract;
using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;
using Hedera.Hashgraph.Reference.Schedule;
using Hedera.Hashgraph.Reference.Token;

using System;
using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Core
{
    public interface ITransactionRecord
    {
        /// <summary>
        /// The byte representation of the encoded protobuf type
        /// </summary>
        byte[] ToBytes();
        /// <summary>
        /// Stringification of all the current values
        /// </summary>
        string ToString();

        /// <summary>
        /// In the record of an internal CryptoCreate transaction triggered by a user transaction with a
        /// (previously unused) alias, the new account's alias.
        /// </summary>
        public IPublicKey AliasKey { get; }
        /// <summary>
        /// In the record of an internal transaction, the consensus timestamp of the user transaction that spawned it.
        /// </summary>
        public IList<IAssessedCustomFee> AssessedCustomFees { get; }
        /// <summary>
        /// In the record of an internal transaction, the consensus timestamp of the user transaction that spawned it.
        /// </summary>
        public IList<ITokenAssociation> AutomaticTokenAssociations { get; }
        /// <summary>
        /// The records of processing all child transaction spawned by the transaction with the given
        /// top-level id, in consensus order.Always empty if the top-level status is UNKNOWN.
        /// </summary>
        public ITransactionRecord Children { get; }
        /// <summary>
        /// The timestamp the transaction came to consensus
        /// </summary>
        public DateTimeOffset ConsensusDateTimeOffset { get; }
        /// <summary>
        /// Result of a ContractExecuteTransaction
        /// </summary>
        public IContractFunctionResult? ContractFunctionResult { get; }
        /// <summary>
        /// The records of processing all consensus transaction with the same id as the distinguished record above, in chronological order.
        /// </summary>
        public ITransactionRecord Duplicates { get; }
        /// <summary>
        /// The keccak256 hash of the ethereumData.
        /// **NOTE**: This field will only be populated for EthereumTransaction.
        /// </summary>
        public byte[] EthereumHash { get; }
        /// <summary>
        /// The EOA 20-byte address to create that is derived from the keccak-256 hash of a ECDSA_SECP256K1 primitive key.
        /// </summary>
        public byte[] EvmAddress { get; }
        /// <summary>
        /// List of accounts with the corresponding staking rewards paid as a result of a transaction.
        /// </summary>
        public ITransfer PaidStakingRewards { get; }
        /// <summary>
        /// In the record of an internal transaction, the consensus timestamp of the user transaction that spawned it.
        /// </summary>
        public DateTimeOffset ParentConsensusDateTimeOffset { get; }
        /// <summary>
        /// In the record of a UtilPrng transaction with no output range, a pseudorandom 384-bit string.
        /// </summary>
        public byte[] PrngBytes { get; }
        /// <summary>
        /// In the record of a PRNG transaction with an output range, the output of a PRNG whose input was a 384-bit string.
        /// </summary>
        public uint PrngNumber { get; }
        /// <summary>
        /// Receipt for the transaction
        /// </summary>
        public ITransactionReceipt Receipt { get; }
        /// <summary>
        /// In the record of an internal transaction, the consensus timestamp of the user transaction that spawned it.
        /// </summary>
        public IScheduleId ScheduleRef { get; }
        /// <summary>
        /// All NFT Token transfers as a result of this transaction
        /// </summary>
        public IDictionary<ITokenId, IList<ITokenNftTransfer>> TokenNftTransfers { get; }
        /// <summary>
        /// All fungible token transfers as a result of this transaction as a list
        /// </summary>
        public IList<ITokenTransfer> TokenTransferList { get; }
        /// <summary>
        /// Any token transfers made in this transaction
        ///
        /// ** Note**: These token transfers are different from the ones set in [`TransferTransaction`] (../cryptocurrency/TransferTransaction.md)
        /// </summary>
        public IDictionary<ITokenId, IList<IAccountId>> TokenTransfers { get; }
        /// <summary>
        /// Fee set on the transaction
        /// </summary>
        public IHbar TransactionFee { get; }
        /// <summary>
        /// Hash of the transaction
        /// </summary>
        public byte[] TransactionHash { get; }
        /// <summary>
        /// Transaction ID of the transaction
        /// </summary>
        public ITransactionId TransactionId { get; }
        /// <summary>
        /// Memo set on the transaction
        /// </summary>
        public string TransactionMemo { get; }
        /// <summary>
        /// Any transfers made in this transaction
        /// ** Note**: Includes fee payments
        /// </summary>
        public ITransfer[] Transfers { get; }
    }

    /// <summary>
    /// Response when the client sends the node TransactionGetRecordResponse
    /// </summary>
    public interface ITransactionRecord<TSelf> : ITransactionRecord where TSelf : ITransactionRecord<TSelf>
    {
        /// <summary>
        /// Decode a `TransactionRecord` from an appropriate protobuf encode structure
        /// </summary>
        abstract static TSelf FromBytes(byte[] data);
    }
}
