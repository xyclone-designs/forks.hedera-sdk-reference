namespace Hedera.Hashgraph.Reference
{
    public interface IEthereumTransactionDataEip1559 : IEthereumTransactionData
    {
        public byte[] ChainId { get; }
        public byte[] Nonce { get; }
        public byte[] MaxPriorityGas { get; }
        public byte[] MaxGas { get; }
        public byte[] GasLimit { get; }
        public byte[] To { get; }
        public byte[] Value { get; }
        public byte[] AccessList { get; }
        public byte[] RecoveryId { get; }
        public byte[] R { get; }
        public byte[] S { get; }
    }
}
