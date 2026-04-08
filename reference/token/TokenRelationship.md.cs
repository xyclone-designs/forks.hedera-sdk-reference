namespace Hedera.Hashgraph.Reference.Token
{
    public interface ITokenRelationship
    {
        abstract static ITokenRelationship FromBytes(byte[] bytes);
        abstract static byte[] ToBytes();

        ITokenId TokenId { get; }
        string Symbol { get; }
        long Balance { get; }
        bool KycStatus { get; }
        bool FreezeStatus { get; }
    }
}
