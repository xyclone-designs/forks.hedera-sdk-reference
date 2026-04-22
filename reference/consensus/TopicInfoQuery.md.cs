namespace Hedera.Hashgraph.Reference.Consensus
{
    /// <summary>
    /// Retrieve the latest state of a topic.
    /// This method is unrestricted and allowed on any topic by any payer account.
    /// </summary>
    public interface ITopicInfoQuery
    {
        /// <summary>
        /// This is the topic ID for which info will be queried for.
        /// </summary>
        ITopicId TopicId { get; set; }
    }
}
