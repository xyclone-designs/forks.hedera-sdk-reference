using Hedera.Hashgraph.Reference.Consensus;
using Hedera.Hashgraph.Reference.Contract;
using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.File;
using Hedera.Hashgraph.Reference.Schedule;
using Hedera.Hashgraph.Reference.Token;

using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// The summary of a transaction's result so far. If the transaction has not reached consensus, this
    /// result will be necessarily incomplete.
    /// </summary>
    public class TransactionReceipt
    {
        /// <summary>
        /// Decode a `TransactionReceipt` from an appropriate protobuf encode structure
        /// </summary>
        public static TransactionReceipt FromBytes(byte[] data);

        /// <summary>
        /// The byte representation of the encoded protobuf type
        /// </summary>
        byte[] ToBytes();

        /// <summary>
        /// Stringification of all the current values
        /// </summary>
        string ToString();

        /// <summary>
        /// An account ID
        ///
        /// **Note**: Only present if this receipt is for an `AccountCreateTransaction`
        /// </summary>
        AccountId? AccountId { get; }

        /// <summary>
        /// The receipts (if any) of all child transactions spawned by the transaction with the
        /// given top-level id, in consensus order.Always empty if the top-level status is UNKNOWN.
        /// </summary>
        ITransactionReceipt Children { get; }

        /// <summary>
        /// A contract ID

        /// **Note**: Only present if this receipt is for an `ContractCreateTransaction`
        /// </summary>
        IContractId? ContractId { get; }

        /// <summary>
        /// The receipts of processing all transactions with the given id, in consensus time order.
        /// </summary>
        IList<ITransactionReceipt> Duplicates { get; }

        /// <summary>
        /// Current exchange rant for Hbar to USD
        /// </summary>
        IExchangeRate ExchangeRate { get; }

        /// <summary>
        /// A file ID

        /// **Note**: Only present if this receipt is for an `FileCreateTransaction`
        /// </summary>
        FileId FileId { get; }
        /// <summary>
        /// In the receipt of a ScheduleCreate, the id of the newly created Scheduled Entity
        /// </summary>
        IScheduleId ScheduleId { get; }
        /// <summary>
        /// In the receipt of a ScheduleCreate or ScheduleSign that resolves to SUCCESS, the
        /// TransactionID that should be used to query for the receipt or record of the relevant
        /// scheduled transaction
        /// </summary>
        TransactionId ScheduleTransactionId { get; }
        /// <summary>
        /// In the receipt of a TokenMint for tokens of type NON\_FUNGIBLE\_UNIQUE, the serial numbers of the newly created NFTs
        /// </summary>
        IList<long> Serials { get; }

        /// <summary>
        /// Status of the submitted transaction.
        /// </summary>
        Status Status { get; }

        /// <summary>
        /// A token ID
        ///
        /// **Note**: Only present if this receipt is for an `TokenCreateTransaction`
        /// </summary>
        TokenId? TokenId { get; }

        /// <summary>
        /// A topic ID
        ///
        /// **Note**: Only present if this receipt is for an `TopicCreateTransaction`
        /// </summary>
        ITopicId? TopicId { get; }

        /// <summary>
        /// The current running hash of the topic
        ///
        /// **Note**: Only present if this receipt is for an `TopicMessageSubmitTransaction`
        /// </summary>
        byte[] TopicRunningHash { get; }

        /// <summary>
        /// The current sequence number of the topic
        ///
        /// **Note**: Only present if this receipt is for an `TopicMessageSubmitTransaction`
        /// </summary>
        long TopicSequenceNumber { get; }

        /// <summary>
        /// The total supply of tokens for the current token
        ///
        /// **Note**: Only present if this receipt is for an `TopicMessageSubmitTransaction`
        /// </summary>
        long TotalSupply { get; }

        /// <summary>
        /// The transaction's ID
        /// </summary>
        TransactionId TransactionId { get; }
    }
}
