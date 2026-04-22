
namespace Hedera.Hashgraph.Reference.Token
{
    public interface ITokenRelationship
    {
        byte[] ToBytes();

        ITokenId TokenId { get; }
        string Symbol { get; }
        long Balance { get; }
        bool KycStatus { get; }
        bool FreezeStatus { get; }
    }

    public interface ITokenRelationship<TSelf> : ITokenRelationship where TSelf : ITokenRelationship<TSelf>
    {
        static abstract ITokenRelationship CTOR(ITokenId tokenId, string symbol, long balance, bool kycStatus, bool freezeStatus);
        static abstract ITokenRelationship FromBytes(byte[] bytes);
    }
}
