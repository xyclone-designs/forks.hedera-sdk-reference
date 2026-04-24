using Hedera.Hashgraph.Reference.Cryptocurrency;

namespace Hedera.Hashgraph.Reference.Token.Airdrops
{
    public interface IPendingAirdropId
    {
        IAccountId Sender { get; set; }
        IAccountId Receiver { get; set; }
        ITokenId? TokenId { get; set; }
        INftId? NftId { get; set; }
    }
    public interface IPendingAirdropId<TSelf> : IPendingAirdropId where TSelf : IPendingAirdropId<TSelf>
    {
        abstract static TSelf CTOR(IAccountId sender, IAccountId receiver, ITokenId tokenId);
        abstract static TSelf CTOR(IAccountId sender, IAccountId receiver, INftId nftId);
    }
}
