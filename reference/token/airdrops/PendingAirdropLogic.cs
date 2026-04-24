using Hedera.Hashgraph.Reference.Core;

using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Token.Airdrops
{
    public interface IPendingAirdropLogic : ITransaction
    {
        IList<IPendingAirdropId> PendingAirdropIds { get; }
    }
}
