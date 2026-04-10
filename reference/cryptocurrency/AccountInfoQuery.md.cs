using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// > extends [`Query`](../core/Query.md) <
    /// > [`AccountInfo`](AccountInfo.md) >
    ///
    /// Get all the information about an account, including the balance. This does not get the list of
    /// account records.
    /// </summary>
    public interface IAccountInfoQuery : IQuery<AccountInfo>
    {
        /// <summary>
        /// The account ID for which information is requested
        /// </summary>
        AccountId AccountId { get; }
    }
}
