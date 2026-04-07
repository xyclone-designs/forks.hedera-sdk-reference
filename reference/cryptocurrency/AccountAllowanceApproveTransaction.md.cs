namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// Creates one or more hbar/token approved allowances <b>relative to the payer account of this
    /// transaction</b>. Each allowance grants a spender the right to transfer a pre-determined
    /// amount of the payer's hbar/token to any other account of the spender's choice.
    ///
    /// (So if account <tt>0.0.X</tt> pays for this transaction, then at consensus each spender
    /// account will have new allowances to spend hbar or tokens from <tt>0.0.X</tt>).
    ///
    /// </summary>
    public interface IAccountAllowanceApproveTransaction
    {
        /// <summary>
        ///
        /// Add a Hbar allowance
        ///
        /// Transaction fee payer is implicitly the allowance owner.
        ///
        /// Deprecated: use `ApproveHbarAllowance` instead.
        ///
        ///
        /// </summary>
        IAccountId AddHbarApproval()

        /// <summary>
        ///
        /// Approve an Hbar allowance
        ///
        ///
        /// </summary>
        IAccountId ApproveHbarAllowance()

        /// <summary>
        ///
        /// Get the current list of hbar approves for this transaction.
        ///
        ///
        /// </summary>
        HbarAllowance GetHbarApprovals()

        /// <summary>
        ///
        /// Add a fungible token approve
        ///
        /// Transaction fee payer is implicitly the allowance owner.
        ///
        /// Deprecated: use `approveTokenAllowance` instead.
        ///
        ///
        /// </summary>
        ITokenId AddTokenApprovals()

        /// <summary>
        ///
        /// Approve a fungible token allowance.
        ///
        ///
        /// </summary>
        ITokenId ApproveTokenAllowance()

        /// <summary>
        ///
        /// Get the current list of hbar approves for this transaction.
        ///
        ///
        /// </summary>
        TokenAllowance GetTokenApprovals()

        /// <summary>
        ///
        /// Add a non-fungible token approve
        ///
        /// Transaction fee payer is implicitly the allowance owner.
        ///
        /// Deprecated: use `approveTokenNftAllowance` instead.
        ///
        ///
        /// </summary>
        NftId AddTokenNftApproval()

        /// <summary>
        ///
        /// Approve a non-fungible token allowance
        ///
        ///
        /// </summary>
        NftId ApproveTokenNftAllowance()

        /// <summary>
        ///
        /// Add all non-fungible tokens to approve
        ///
        /// Transaction fee payer is implicitly the allowance owner.
        ///
        /// Deprecated: use `approveTokenNftAllowanceAllSerials` instead.
        ///
        ///
        /// </summary>
        ITokenId AddAllTokenNftApprovals()

        /// <summary>
        ///
        /// Approve an allowance of all serial numbers of a non-fungible token.
        ///
        ///
        /// </summary>
        ITokenId ApproveTokenNftAllowanceAllSerials()

        /// <summary>
        ///
        /// Get the list of all non-fungible token approves for this transaction
        ///
        /// </summary>
        TokenNftAllowance GetTokenNftApprovals()

    }
}
