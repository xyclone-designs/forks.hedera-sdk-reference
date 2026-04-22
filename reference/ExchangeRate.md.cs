using System;

namespace Hedera.Hashgraph.Reference
{
    public interface IExchangeRate
    {
        IHbar IHbars { get; }
        int Cents { get; }
        DateTimeOffset ExpirationTime { get; }
    }
}
