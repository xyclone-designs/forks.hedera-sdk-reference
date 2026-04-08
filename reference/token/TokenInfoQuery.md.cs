using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Token
{
    public interface ITokenInfoQuery : IQuery<ITokenInfo>
    {
        ITokenId TokenId { get; }
    }
}
