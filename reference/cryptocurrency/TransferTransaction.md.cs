namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// Transfers cryptocurrency among two or more accounts by making the desired adjustments to their
    /// balances. Each transfer list can specify up to 10 adjustments. Each negative amount is withdrawn
    /// from the corresponding account (a sender), and each positive one is added to the corresponding
    /// account (a receiver). The amounts list must sum to zero. Each amount is a number of tinybars
    /// (there are 100,000,000 tinybars in one hbar).  If any sender account fails to have sufficient
    /// hbars, then the entire transaction fails, and none of those transfers occur, though the
    /// transaction fee is still charged. This transaction must be signed by the keys for all the sending
    /// accounts, and for any receiving accounts that have receiverSigRequired == true. The signatures
    /// are in the same order as the accounts, skipping those accounts that don't need a signature.
    ///
    /// </summary>
    public interface ITransferTransaction
    {
        /// <summary>
        ///
        /// Add an Hbar transfer
        ///
        ///
        /// </summary>
        ITransferTransaction AddHbarTransfer(IAccountId accountId, Hbar amount)

        /// <summary>
        ///
        /// Add an approved Hbar transfer
        ///
        ///
        /// </summary>
        ITransferTransaction AddApprovedHbarTransfer(IAccountId accountId, Hbar amount)

        /// <summary>
        ///
        /// The Hbar transfers
        ///
        ///
        /// </summary>
        IAccountId GetHbarTransfers()

        /// <summary>
        ///
        /// Add a fungible token transfer
        ///
        ///
        /// </summary>
        ITransferTransaction AddTokenTransfer(ITokenId tokenId, Uint64 ) amount)

        /// <summary>
        ///
        /// Add an approved fungible token transfer
        ///
        ///
        /// </summary>
        ITransferTransaction AddApprovedTokenTransfer(ITokenId tokenId, Uint64 ) amount)

        /// <summary>
        ///
        /// Add an approved fungible token transfer with an expected decimals field
        ///
        ///
        /// </summary>
        ITransferTransaction AddTokenTransferWithDecimals(ITokenId tokenId, long amount, Uint32 ) decimals)

        /// <summary>
        ///
        /// Add an approved fungible token transfer with an expected decimals field
        ///
        ///
        /// </summary>
        ITransferTransaction AddApproovedTokenTransferWithDecimals(ITokenId tokenId, long amount, Uint32 ) decimals)

        /// <summary>
        ///
        /// The expected decimals per token ID
        ///
        ///
        /// </summary>
        ITokenId GetTokenIdDecimals()

        /// <summary>
        ///
        /// The fungible token transfers
        ///
        ///
        /// </summary>
        ITokenId GetTokenTransfers()

        /// <summary>
        ///
        /// Add a non-fungible token transfer
        ///
        ///
        /// </summary>
        ITransferTransaction AddNftTransfer(NftId nftId, IAccountId sender, IAccountId reciever)

        /// <summary>
        ///
        /// Add an approved non-fungible token transfer
        ///
        ///
        /// </summary>
        ITransferTransaction AddApprovedNftTransfer(NftId nftId, IAccountId sender, IAccountId reciever)

        /// <summary>
        ///
        /// The non-fungible token transfers
        ///
        /// </summary>
        ITokenId GetTokenNftTransfers()

    }
}
