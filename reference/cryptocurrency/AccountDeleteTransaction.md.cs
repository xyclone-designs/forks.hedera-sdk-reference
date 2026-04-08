using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// Mark an account as deleted, moving all its current hbars to another account. It will remain in
    /// the ledger, marked as deleted, until it expires. Transfers into it a deleted account fail. But a
    /// deleted account can still have its expiration extended in the normal way.
    ///
    /// > [!WARNING]
    /// > When you delete an account, you need to sign it with the key set at account creation.
    /// </summary>
    public interface IAccountDeletedTransaction : ITransaction
    {
        /// <summary>
        /// The AccountId which should be deleted
        /// </summary>
        IAccountId AccountId { get; }

        /// <summary>
        /// The `AccountId` which will receive all remaining hbars
        /// </summary>
        IAccountId TransferAccountId { get; }
    }
}
