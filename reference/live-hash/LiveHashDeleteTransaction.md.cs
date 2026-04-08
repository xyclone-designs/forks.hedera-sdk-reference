using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;

namespace Hedera.Hashgraph.Reference.LiveHash
{
    public interface ILiveHashDeleteTransaction : ITransaction
    {
        IAccountId AccountId { get; }
        byte[] Hash { get; }
    }
}
