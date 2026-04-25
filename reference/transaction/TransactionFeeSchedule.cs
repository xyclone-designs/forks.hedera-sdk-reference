using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Transaction
{
    public interface ITransactionFeeSchedule { }
    public interface ITransactionFeeSchedule<TSelf> : ITransaction where TSelf : ITransactionFeeSchedule<TSelf> { }
}
