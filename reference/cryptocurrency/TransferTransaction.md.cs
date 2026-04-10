using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Token;

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
    /// </summary>
    public interface ITransferTransaction : ITransaction
    {
        /// <summary>
        /// Add an Hbar transfer
        /// </summary>
        ITransferTransaction AddHbarTransfer(AccountId accountId, Hbar amount);

        /// <summary>
        /// Add an approved Hbar transfer
        /// </summary>
        ITransferTransaction AddApprovedHbarTransfer(AccountId accountId, Hbar amount);

        /// <summary>
        /// The Hbar transfers
        /// </summary>
        AccountId GetHbarTransfers();

        /// <summary>
        /// Add a fungible token transfer
        /// </summary>
        ITransferTransaction AddTokenTransfer(TokenId tokenId, long amount);

        /// <summary>
        /// Add an approved fungible token transfer
        /// </summary>
        ITransferTransaction AddApprovedTokenTransfer(TokenId tokenId, long amount);

        /// <summary>
        /// Add an approved fungible token transfer with an expected decimals field
        /// </summary>
        ITransferTransaction AddTokenTransferWithDecimals(TokenId tokenId, long amount, int decimals);

        /// <summary>
        /// Add an approved fungible token transfer with an expected decimals field
        /// </summary>
        ITransferTransaction AddApproovedTokenTransferWithDecimals(TokenId tokenId, long amount, int decimals);

        /// <summary>
        /// The expected decimals per token ID
        /// </summary>
        TokenId GetTokenIdDecimals();

        /// <summary>
        /// The fungible token transfers
        /// </summary>
        TokenId GetTokenTransfers();

        /// <summary>
        /// Add a non-fungible token transfer
        /// </summary>
        ITransferTransaction AddNftTransfer(NftId nftId, AccountId sender, AccountId reciever);

        /// <summary>
        /// Add an approved non-fungible token transfer
        /// </summary>
        ITransferTransaction AddApprovedNftTransfer(NftId nftId, AccountId sender, AccountId reciever);

        /// <summary>
        /// The non-fungible token transfers
        /// </summary>
        TokenId GetTokenNftTransfers();
    }
}
