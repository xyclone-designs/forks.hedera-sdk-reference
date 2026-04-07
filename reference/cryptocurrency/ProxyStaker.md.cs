namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// Information about a single account that is proxy staking
    ///
    /// </summary>
    public interface IProxyStaker
    {
        /// <summary>
        ///
        /// The Account ID that is proxy staking
        ///
        ///
        /// </summary>
        IAccountId AccountId { get; }

        /// <summary>
        ///
        /// The number of hbars that are currently proxy staked
        ///
        /// </summary>
        Hbar Amount { get; }

    }
}
