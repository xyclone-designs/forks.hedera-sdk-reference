
namespace Hedera.Hashgraph.Reference.Hook
{
    public interface IHookEntityId { }
    public interface IHookEntityId<TSelf> : IHookEntityId where TSelf : IHookEntityId<TSelf> { }
}
