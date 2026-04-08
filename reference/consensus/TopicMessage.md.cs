
namespace Hedera.Hashgraph.Reference.Consensus
{
    public interface ITopicMessage
    {
        /// <summary>
        /// The consensus timestamp of this topic message. If this message was chunked, this
        /// field would be equal to the last chunk's consensus timestamp.
        /// </summary>
        Timestamp ConsensusTimestamp { get; set; }
        /// <summary>
        /// The contents of this topic message. If this message was chunked, this field would
        /// be equal to the concatination of all the chunks.
        /// </summary>
        byte[] Contents { get; set; }
        /// <summary>
        /// The running hash of this topic message. If this message was chunked this field would
        /// be equal to the last chunk's running hash.
        /// </summary>
        byte[] RunningHash { get; set; }
        /// <summary>
        /// The sequence number of this topic message. If this message was chunked this field would
        /// be equal to the last chunk's sequence number.
        /// </summary>
        long SequenceNumber { get; set; }
        /// <summary>
        /// The chunks of this topic message. Will be null if this topic message was not chunked.
        /// Otherwise will contain an ordered list of chunks for this topic message.
        /// </summary>
        ITopicMessageChunk[] Chunks { get; set; }
    }
}
