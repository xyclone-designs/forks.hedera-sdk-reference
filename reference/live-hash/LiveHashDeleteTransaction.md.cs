namespace Hedera.Hashgraph.Reference.LiveHash
{
    /// <summary>
    /// </summary>
    public interface ILiveHashAddTransaction
    {
        /// <summary>
        ///
        ///
        /// </summary>
        IAccountId AccountId { get; }

        /// <summary>
        ///
        ///
        /// </summary>
        byte[] Hash { get; }

    }
}
