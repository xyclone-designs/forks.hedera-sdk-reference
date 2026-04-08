using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;

namespace Hedera.Hashgraph.Reference.LiveHash
{
    public interface ILiveHashAddTransaction : ITransaction
    {
        IAccountId AccountId { get; }
        byte[] Hash { get; }
        IKeyList Keys { get; }
        Duration Duration { get; }
    }
}
