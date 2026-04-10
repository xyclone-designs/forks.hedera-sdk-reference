using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;

namespace Hedera.Hashgraph.Reference.LiveHash
{
    public interface ILiveHashDeleteTransaction : ITransaction
    {
        AccountId AccountId { get; }
        byte[] Hash { get; }
    }
}
