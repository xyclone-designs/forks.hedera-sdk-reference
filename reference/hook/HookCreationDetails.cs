
namespace Hedera.Hashgraph.Reference.Hook
{
    public interface IHookCreationDetails { }
    public interface IHookCreationDetails<TSelf> : IHookCreationDetails where TSelf : IHookCreationDetails<TSelf> { }
}
