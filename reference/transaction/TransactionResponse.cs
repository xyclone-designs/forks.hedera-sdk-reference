using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Transaction
{
    public interface ITransactionResponse { }
    public interface ITransactionResponse<TSelf> : ITransaction where TSelf : ITransactionResponse<TSelf> { }
}
