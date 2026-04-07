namespace Hedera.Hashgraph.Reference.Consensus
{
    /// <summary>
    /// Current state of the topic
    ///
    /// </summary>
    public interface ITopicInfo
    {
        /// <summary>
        ///
        /// Deserialize a [`TopicInfo`](#) from its the protobuf representation.
        ///
        ///
        /// </summary>
        abstract static ITopicInfo FromBytes(byte[] data)

        /// <summary>
        ///
        /// Serialize the [`TopicInfo`](#) into its protobuf representation.
        ///
        ///
        /// </summary>
        byte[] ToBytes()

        /// <summary>
        ///
        /// The ID for which this info belongs to.
        ///
        ///
        /// </summary>
        ITopicId TopicId { get; }

        /// <summary>
        ///
        /// The memo set on the topic.
        ///
        ///
        /// </summary>
        string TopicMemo { get; }

        /// <summary>
        ///
        /// The current running hash of the last topic message.
        ///
        ///
        /// </summary>
        byte[] RunningHash { get; }

        /// <summary>
        ///
        /// The sequence number of the last topic message.
        ///
        ///
        /// </summary>
        long SequenceNumber { get; }

        /// <summary>
        ///
        /// The timestamp when this topic will expire which will effectively delete this topic.
        ///
        ///
        /// </summary>
        Timestamp ExpirationTime { get; }

        /// <summary>
        ///
        /// The key that is required to sign transactions that mutate this topic.
        ///
        ///
        /// </summary>
        Key AdminKey { get; }

        /// <summary>
        ///
        /// The key that is required to sign transactions that submit messages to this topic.
        ///
        ///
        /// </summary>
        Key SubmitKey { get; }

        /// <summary>
        ///
        /// The duration since topic creation when this topic will be auto renewed and the auto renew account will be charged.
        ///
        ///
        /// </summary>
        Duration AutoRenewPeriod { get; }

        /// <summary>
        ///
        /// The auto renew account that will be charged when the topic is to be auto renewed.
        ///
        ///
        /// </summary>
        IAccountId AutoRenewAccountId { get; }

        /// <summary>
        ///
        /// The ID of the ledger which returned this response
        ///
        /// </summary>
        ILedgerId LedgerId { get; }

    }
}
