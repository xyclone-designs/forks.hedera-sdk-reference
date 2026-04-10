using System;

namespace Hedera.Hashgraph.Reference
{
    public interface IExchangeRate
    {
        Hbar Hbars { get; }
        int Cents { get; }
        DateTimeOffset ExpirationTime { get; }
    }
}
