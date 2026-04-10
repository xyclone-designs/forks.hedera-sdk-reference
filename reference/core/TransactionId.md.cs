using Hedera.Hashgraph.Reference.Cryptocurrency;

using System;

namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// The client-generated ID for a transaction.
    /// </summary>
    public abstract class TransactionId
    {
        /// <summary>
        /// Construct the transaction ID from a protobuf encoded `TransactionID`
        /// </summary>
        public static TransactionId FromBytes(byte[] data) => throw new NotImplementedException();
        /// <summary>
        /// Construct a transaction ID from string
        ///
        /// **NOTE**: The transaction ID format is
        /// `(?<accountId>(\d+.\d+)?\d+)\.(?<timestamp>\d+.\d+)(?<scheduled>\?scheduled)?(?<nonce>/\d+)?`
        /// </summary>
        public static TransactionId FromString(string text) => throw new NotImplementedException();
        /// <summary>
        /// Generate a transaction ID with the given account ID and a generated timestamp
        /// </summary>
        public static TransactionId Generate(AccountId accountId) => throw new NotImplementedException();
        /// <summary>
        /// Fetch the receipt of the transaction.
        /// </summary>
        public static TransactionReceipt GetReceipt(Client client) => throw new NotImplementedException();
        /// <summary>
        /// Fetch the record of the transaction.
        /// </summary>
        public static TransactionRecord GetRecord(Client client) => throw new NotImplementedException();
        /// <summary>
        /// Create a transaction id.
        /// </summary>
        public static TransactionId WithValidStart(AccountId accountId, DateTimeOffset validStart) => throw new NotImplementedException();

        /// <summary>
        /// Stringify the transaction ID
        /// </summary>
        public override string ToString() => throw new NotImplementedException();
        /// <summary>
                                                                                         /// Convert to a string representation with checksum
                                                                                         /// </summary>
        public abstract string ToStringWithChecksum(Client client);
        /// <summary>
        /// Serialize the transaction into protobuf encoded bytes
        /// </summary>
        public abstract byte[] ToBytes();

        /// <summary>
        /// The account ID of the transaction ID
        ///
        /// This account pays for the transaction
        /// </summary>
        public AccountId AccountId { get; }
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
}
