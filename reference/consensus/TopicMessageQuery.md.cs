
namespace Hedera.Hashgraph.Reference.Consensus
{
    public interface ITopicMessageQuery
    {
        /// <summary>
        /// The ID for a topic to subscribe to.
        /// </summary>
        TopicId TopicId { get; }
    }
}
