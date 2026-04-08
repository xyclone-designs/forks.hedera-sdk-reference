using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Consensus
{
    public interface ITopicSubmitTransaction : ITransaction
    {
        /// <summary>
        /// Topic to submit message to.
        /// </summary>
        ITopicId TopicId { get; }

        /// <summary>
        /// Message to be submitted. Max size of the Transaction (including signatures) is 6KiB.
        /// </summary>
        byte[] Message { get; }
    }
}
