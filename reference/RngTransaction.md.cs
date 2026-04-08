namespace Hedera.Hashgraph.Reference
{
    /// <summary>
    /// https://hips.hedera.com/hip/hip-351
    /// </summary>
    public interface IRngTransaction
    {
        /// <summary>
        /// If provided and is positive, returns a 32-bit pseudorandom number from the
        /// given range in the transaction record. If not set or set to zero, will return a
        /// 384-bit pseudorandom number in the record.
        /// </summary>
        long? Range { get; }
    }
}
