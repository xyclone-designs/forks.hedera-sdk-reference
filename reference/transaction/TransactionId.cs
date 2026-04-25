using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Transaction
{
    public interface ITransactionId { }
    public interface ITransactionId<TSelf> : ITransaction where TSelf : ITransactionId<TSelf> { }
}
