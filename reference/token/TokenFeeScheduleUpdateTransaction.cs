using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Fee;

using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Token
{
    public interface ITokenFeeScheduleUpdateTransaction : ITransaction
    {
        ITokenId? TokenId { get; }
        IList<ICustomFee> CustomFees { get; }
    }
}
