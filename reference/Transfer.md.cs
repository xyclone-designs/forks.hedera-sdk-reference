// SPDX-License-Identifier: Apache-2.0
using Hedera.Hashgraph.Reference.Cryptocurrency;

namespace Hedera.Hashgraph.Reference
{
    public interface ITransfer
    {
        IAccountId AccountId { get; }
        IHbar Amount { get; }
    }
}
