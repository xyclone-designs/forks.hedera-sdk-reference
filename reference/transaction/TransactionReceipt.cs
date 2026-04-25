using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Transaction
{
    public interface ITransactionReceipt { }
    public interface ITransactionReceipt<TSelf> : ITransaction where TSelf : ITransactionReceipt<TSelf> { }
}
