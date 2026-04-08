namespace Hedera.Hashgraph.Reference.Consensus
{
    public interface ITopicMessageChunk
    {
        /// <summary>
        /// The consensus timestamp of this topic message chunk.
        /// </summary>
        Timestamp ConsensusTimestamp { get; set; }
        /// <summary>
        /// The contents of this topic message chunk.
        /// </summary>
        byte[] Contents { get; set; }
        /// <summary>
        /// The running hash of this topic message chunk.
        /// </summary>
        byte[] RunningHash { get; set; }
        /// <summary>
        /// The sequence number of this topic message chunk.
        /// </summary>
        long SequenceNumber { get; set; }

    }
}
