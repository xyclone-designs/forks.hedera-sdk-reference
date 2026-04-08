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
        IAccountId AddHbarAllowance();

        /// <summary>
        /// Increase an Hbar Allowance.
        /// </summary>
        IAccountId GrantHbarAllowance();

        /// <summary>
        /// Decrease an Hbar Allowance.
        /// </summary>
        IAccountId RevokeHbarAllowance();

        /// <summary>
        /// Get the current list of hbar allowances for this transaction.
        /// </summary>
        HbarAllowance GetHbarAllowances();

        /// <summary>
        /// Add a fungible token allowance
        ///
        /// Transaction fee payer is implicitly the allowance owner.
        ///
        /// Deprecated: use `[grant|revoke]TokenAllowance` instead.
        /// </summary>
        ITokenId AddTokenAllowance();

        /// <summary>
        /// Increase a fungible token allowance.
        /// </summary>
        ITokenId GrantTokenAllowance();

        /// <summary>
        /// Decrease a fungible token allowance.
        /// </summary>
        ITokenId RevokeTokenAllowance();

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
        ITokenId AddAllTokenNftAllowance();

        /// <summary>
        /// Add all serials to a non-fungible token allowance.
        /// </summary>
        ITokenId GrantTokenNftAllowanceAllSerials();

        /// <summary>
        /// Remove all serials from a non-fungible token allowance.
        /// </summary>
        ITokenId RevokeTokenNftAllowanceAllSerials();

        /// <summary>
        /// Get the list of all non-fungible token allowances for this transaction
        /// </summary>
        TokenNftAllowance GetTokenNftAllowances();
    }
}
