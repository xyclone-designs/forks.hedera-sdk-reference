using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Transaction
{
    public interface ITransactionRecord { }
    public interface ITransactionRecord<TSelf> : ITransaction where TSelf : ITransactionRecord<TSelf> { }
}
