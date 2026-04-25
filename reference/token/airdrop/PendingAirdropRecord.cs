
namespace Hedera.Hashgraph.Reference.Token.Airdrop
{
    public interface IPendingAirdropRecord
    {
        ulong PendingAirdropAmount { get; }
        IPendingAirdropId PendingAirdropId { get; }
    }
    public interface IPendingAirdropRecord<TSelf> : IPendingAirdropRecord where TSelf : IPendingAirdropRecord<TSelf>
    {
        abstract static TSelf CTOR(IPendingAirdropId pendingAirdropId, ulong pendingAirdropAmount);
    }
}
