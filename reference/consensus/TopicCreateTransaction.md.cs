using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;

using System;

namespace Hedera.Hashgraph.Reference.Consensus
{
    public interface ITopicCreateTransaction : ITransaction
    {
        /// <summary>
        /// Access control for updating/deleting.
        /// If no adminKey is specified, updateTopic may only be used to extend the topic's `expirationTime`, and deletion
        /// is disallowed.
        /// </summary>
        IKey AdminKey { get; }
        /// <summary>
        /// Access control for submitMessage. If unspecified, no access control is performed (all submissions are allowed).
        /// </summary>
        IKey SubmitKey { get; }
        /// <summary>
        /// The initial lifetime of the topic and the amount of time to attempt to extend the topic's lifetime by
        /// automatically at the topic's `expirationTime`, if the `autoRenewAccountId` is configured
        /// </summary>
        TimeSpan AutoRenewPeriod { get; }
        /// <summary>
        /// Optional account to be used at the topic's `expirationTime` to extend the life of the topic.
        /// The topic lifetime will be extended up to a maximum of the `autoRenewPeriod` or however long the topic
        /// can be extended using all funds on the account.
        /// If specified, there must be an `adminKey` and the `autoRenewAccount` must sign this transaction.
        /// </summary>
        AccountId AutoRenewAccountId { get; }
        /// <summary>
        /// Short publicly visible memo about the topic. No guarantee of uniqueness.
        /// </summary>
        string TopicMemo { get; }
    }
}
