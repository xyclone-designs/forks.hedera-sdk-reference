using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Token;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// <b>WARNING</b>: This class has been **deprecated** and is no longer supported by the Hedera protobufs.
    ///
    /// Modifies or creates the hbar/token allowance for a spender <b>relative to the payer account
    /// of this transaction</b>.
    ///
    /// (So if account <tt>0.0.X</tt> pays for this transaction, then at consensus the spender
    /// account will have new allowances to spend hbar or tokens from <tt>0.0.X</tt>).
    ///
    /// <b>IMPORTANT</b>: If an allowance for the spender does not currently exist, this transaction
    /// behaves like an allowance approval.
    /// </summary>
    public interface IAccountAllowanceAdjustTransaction : ITransaction
    {
        /// <summary>
        /// Add a Hbar allowance
        ///
        /// Transaction fee payer is implicitly the allowance owner.
        ///
        /// Deprecated: use `[grant|revoke]HbarAllowance` instead.
        /// </summary>
        AccountId AddHbarAllowance();
        /// <summary>
        /// Increase an Hbar Allowance.
        /// </summary>
        AccountId GrantHbarAllowance();
        /// <summary>
        /// Decrease an Hbar Allowance.
        /// </summary>
        AccountId RevokeHbarAllowance();
        /// <summary>
        /// Get the current list of hbar allowances for this transaction.
        /// </summary>
        IHbarAllowance GetHbarAllowances();
        /// <summary>
        /// Add a fungible token allowance
        ///
        /// Transaction fee payer is implicitly the allowance owner.
        ///
        /// Deprecated: use `[grant|revoke]TokenAllowance` instead.
        /// </summary>
        TokenId AddTokenAllowance();
        /// <summary>
        /// Increase a fungible token allowance.
        /// </summary>
        TokenId GrantTokenAllowance();
        /// <summary>
        /// Decrease a fungible token allowance.
        /// </summary>
        TokenId RevokeTokenAllowance();
        /// <summary>
        /// Get the current list of hbar allowances for this transaction.
        /// </summary>
        TokenAllowance GetTokenAllowances();
        /// <summary>
        /// Add a non-fungible token allowance
        ///
        /// Transaction fee payer is implicitly the allowance owner.
        ///
        /// Deprecated: use `[grant|revoke]TokenNftAllowance` instead.
        /// </summary>
        NftId AddTokenNftAllowance();
        /// <summary>
        /// Add serials to a non-fungible token allowance.
        /// </summary>
        NftId GrantTokenNftAllowance();
        /// <summary>
        /// Remove serials from a non-fungible token allowance.
        /// </summary>
        NftId RevokeTokenNftAllowance();
        /// <summary>
        /// Add all non-fungible tokens to allowance
        ///
        /// Transaction fee payer is implicitly the allowance owner.
        ///
        /// Deprecated: use `[grant|revoke]TokenNftAllowanceAllSerials` instead.
        /// </summary>
        TokenId AddAllTokenNftAllowance();
        /// <summary>
        /// Add all serials to a non-fungible token allowance.
        /// </summary>
        TokenId GrantTokenNftAllowanceAllSerials();
        /// <summary>
        /// Remove all serials from a non-fungible token allowance.
        /// </summary>
        TokenId RevokeTokenNftAllowanceAllSerials();
        /// <summary>
        /// Get the list of all non-fungible token allowances for this transaction
        /// </summary>
        ITokenNftAllowance GetTokenNftAllowances();
    }
}
