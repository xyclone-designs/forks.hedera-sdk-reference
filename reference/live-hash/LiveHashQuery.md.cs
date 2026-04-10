using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;

namespace Hedera.Hashgraph.Reference.LiveHash
{
    /// <summary>
    /// Returns the full livehash associated to an account, if it is present. Note that the only way to
    /// obtain a state proof exhibiting the absence of a livehash from an account is to retrieve a state
    /// proof of the entire account with its list of livehashes.
    /// </summary>
    public interface ILiveHashQuery : IQuery<ILiveHash>
    {
        /// <summary>
        /// The Account for which information is being requested.
        /// </summary>
        AccountId AccountId { get; }
        byte[] Hash { get; }
    }
}
