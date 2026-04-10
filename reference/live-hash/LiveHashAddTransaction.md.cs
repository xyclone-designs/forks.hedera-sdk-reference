using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;

using System;

namespace Hedera.Hashgraph.Reference.LiveHash
{
    public interface ILiveHashAddTransaction : ITransaction
    {
        AccountId AccountId { get; }
        byte[] Hash { get; }
        KeyList Keys { get; }
        TimeSpan TimeSpan { get; }
    }
}
