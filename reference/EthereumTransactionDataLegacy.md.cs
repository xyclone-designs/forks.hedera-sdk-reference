namespace Hedera.Hashgraph.Reference
{
    public interface IEthereumTransactionDataLegacy : IEthereumTransactionData
    {
        public byte[] Nonce { get; }
        public byte[] GasPrice { get; }
        public byte[] GasLimit { get; }
        public byte[] To { get; }
        public byte[] Value { get; }
        public byte[] V { get; }
        public byte[] R { get; }
        public byte[] S { get; }
    }
}
