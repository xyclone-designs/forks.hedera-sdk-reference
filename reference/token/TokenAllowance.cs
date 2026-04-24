using Hedera.Hashgraph.Reference.Cryptocurrency;

namespace Hedera.Hashgraph.Reference.Token
{
    public interface ITokenAllowance
    {
        ITokenId TokenId { get; }
        IAccountId? OwnerAccountId { get; }
        IAccountId? SpenderAccountId { get; }
        long Amount { get; }
    }
    public interface ITokenAllowance<TSelf> : ITokenAllowance where TSelf : ITokenAllowance<TSelf>
    {
        abstract static TSelf CTOR(ITokenId tokenId, IAccountId? ownerAccountId, IAccountId? spenderAccountId, long amount);
    }
}
