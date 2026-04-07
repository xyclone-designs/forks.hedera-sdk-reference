namespace Hedera.Hashgraph.Reference.Consensus
{
    /// <summary>
    /// </summary>
    public interface ITopicCreateTransaction
    {
        /// <summary>
        ///
        /// Access control for updating/deleting.
        /// If no adminKey is specified, updateTopic may only be used to extend the topic's `expirationTime`, and deletion
        /// is disallowed.
        ///
        ///
        /// </summary>
        Key AdminKey { get; }

        /// <summary>
        ///
        /// Access control for submitMessage. If unspecified, no access control is performed (all submissions are allowed).
        ///
        ///
        /// </summary>
        Key SubmitKey { get; }

        /// <summary>
        ///
        /// The initial lifetime of the topic and the amount of time to attempt to extend the topic's lifetime by
        /// automatically at the topic's `expirationTime`, if the `autoRenewAccountId` is configured
        ///
        ///
        /// </summary>
        Duration AutoRenewPeriod { get; }

        /// <summary>
        ///
        /// Optional account to be used at the topic's `expirationTime` to extend the life of the topic.
        /// The topic lifetime will be extended up to a maximum of the `autoRenewPeriod` or however long the topic
        /// can be extended using all funds on the account.
        /// If specified, there must be an `adminKey` and the `autoRenewAccount` must sign this transaction.
        ///
        ///
        /// </summary>
        IAccountId AutoRenewAccountId { get; }

        /// <summary>
        ///
        /// Short publicly visible memo about the topic. No guarantee of uniqueness.
        ///
        /// </summary>
        string TopicMemo { get; }

    }
}
