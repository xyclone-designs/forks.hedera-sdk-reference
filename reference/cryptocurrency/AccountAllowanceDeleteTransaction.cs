using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Token;
using Hedera.Hashgraph.Reference.Token.Nft;

using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    public interface IAccountAllowanceDeleteTransaction : ITransaction
    {
        IList<IHbarAllowance> GetHbarAllowanceDeletions();
        IList<ITokenAllowance> GetTokenAllowanceDeletions();
        IList<ITokenNftAllowance> GetTokenNftAllowanceDeletions();
        IAccountAllowanceDeleteTransaction DeleteAllHbarAllowances(IAccountId ownerAccountId);
        IAccountAllowanceDeleteTransaction DeleteAllTokenAllowances(ITokenId tokenId, IAccountId ownerAccountId);
        IAccountAllowanceDeleteTransaction DeleteAllTokenNftAllowances(INftId nftId, IAccountId ownerAccountId);
    }
}
