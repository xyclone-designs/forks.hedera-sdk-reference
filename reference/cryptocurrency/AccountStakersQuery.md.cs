using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// Get all the accounts that are proxy staking to this account. For each of them, give the amount
    /// currently staked.This is not yet implemented, but will be in a future version of the API.

    /// </summary>
    public interface IAccountStakersQuery : IQuery<IProxyStaker[]>
    {
        /// <summary>
        /// The account ID for which the records should be retrieved
        /// </summary>
        AccountId AccountId { get; }
    }
}
