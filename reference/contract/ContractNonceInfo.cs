
namespace Hedera.Hashgraph.Reference.Contract
{
    public interface IContractNonceInfo
    {
        IContractId ContractId { get; }
        long Nonce { get; }
    }

    public interface IContractNonceInfo<TSelf> : IContractNonceInfo where TSelf : IContractNonceInfo<TSelf>
    {
        abstract static TSelf CTOR(IContractId contractId, long nonce);
    }
}
