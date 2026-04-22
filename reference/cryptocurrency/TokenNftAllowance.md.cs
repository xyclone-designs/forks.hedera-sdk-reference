using Hedera.Hashgraph.Reference.Token;

using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    public interface ITokenNftAllowance
    {
        /// <summary>
        /// The account ID of the hbar owner(ie.the grantor of the allowance).
        /// </summary>
        IAccountId OwnerAccountId { get; }

        /// <summary>
        /// The token that the allowance pertains to.
        /// </summary>
        ITokenId TokenId { get; }

        /// <summary>
        /// The account ID of the spender of the hbar allowance.
        /// </summary>
        IAccountId SpenderAccountId { get; }

        /// <summary>
        /// The current balance of the spender's token allowance.
        /// </summary>
        IList<long> SerialNumbers { get; }

        /// <summary>
        /// A `true` value indicates that this allowance pertains to all serial numbers.
        /// In the context of a[`AccountAllowanceAdjustTransaction`](reference/cryptocurrency/AccountAllowanceAdjustTransaction.md),
        /// a `false` value(in contrast to `null`) indicates that allowances for all serial numbers shall be _revoked_.
        /// </summary>
        bool? AllSerials { get; }
    }
}
