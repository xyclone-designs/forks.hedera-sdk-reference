namespace Hedera.Hashgraph.Reference
{
    public interface IEthereumTransactionDataEip1559 : IEthereumTransactionData
    {
        byte[] ChainId { get; }
        byte[] Nonce { get; }
        byte[] MaxPriorityGas { get; }
        byte[] MaxGas { get; }
        byte[] GasLimit { get; }
        byte[] To { get; }
        byte[] Value { get; }
        byte[] AccessList { get; }
        byte[] RecoveryId { get; }
        byte[] R { get; }
        byte[] S { get; }
    }
}
