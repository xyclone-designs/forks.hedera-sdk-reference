
namespace Hedera.Hashgraph.Reference
{
    public interface IExchangeRate
    {
        IHbar Hbars { get; }
        int Cents { get; }
        Timestamp ExpirationTime { get; }
    }
}
