using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;

using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Token.Airdrops
{
    public interface IAbstractTokenTransferTransaction<TSelf> : ITransaction where TSelf : IAbstractTokenTransferTransaction<TSelf>
    {
        IDictionary<ITokenId, uint?> GetTokenIdDecimals();
        IDictionary<ITokenId, IDictionary<IAccountId, long>> GetTokenTransfers();
        IDictionary<ITokenId, IList<ITokenNftTransfer>> GetTokenNftTransfers();

        TSelf AddApprovedNftTransfer(INftId nftId, IAccountId sender, IAccountId receiver);
        TSelf AddApprovedTokenTransfer(ITokenId tokenId, IAccountId accountId, long value);
        TSelf AddTokenTransferWithDecimals(ITokenId tokenId, IAccountId accountId, long value, uint decimals);
        TSelf AddApprovedTokenTransferWithDecimals(ITokenId tokenId, IAccountId accountId, long value, uint decimals);
        TSelf AddNftTransfer(INftId nftId, IAccountId sender, IAccountId receiver);
        TSelf AddTokenTransfer(ITokenId tokenId, IAccountId accountId, long value);
        TSelf SetNftTransferApproval(INftId nftId, bool isApproved);
        TSelf SetTokenTransferApproval(ITokenId tokenId, IAccountId accountId, bool isApproved);
    }
}
