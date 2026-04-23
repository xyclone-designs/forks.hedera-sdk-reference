
namespace Hedera.Hashgraph.Reference.Contract
{
    public interface IDelegateContractId { }
    public interface IDelegateContractId<TSelf> : IDelegateContractId where TSelf : IDelegateContractId<TSelf> { }
}
