namespace Hedera.Hashgraph.Reference.Consensus
{
    /// <summary>
    /// </summary>
    public interface ITopicDeleteTransaction
    {
        /// <summary>
        ///
        /// The `topicId` which should be deleted
        ///
        /// </summary>
        ITopicId TopicId { get; }

    }
}
