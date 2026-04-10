using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptography;

using System;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// Change properties for the given account. Any null field is ignored (left unchanged). This
    /// transaction must be signed by the existing key for this account. If the transaction is changing
    /// the key field, then the transaction must be signed by both the old key (from before the change)
    /// and the new key. The old key must sign for security. The new key must sign as a safeguard to
    /// avoid accidentally changing to an invalid key, and then having no way to recover.
    /// </summary>
    public interface IAccountUpdateTransaction : ITransaction
    {
        /// <summary>
        /// The account ID which is being updated in this transaction
        /// </summary>
        AccountId AccountId { get; }

        /// <summary>
        /// If set, the new memo to be associated with the account (UTF-8 encoding max 100 bytes)
        /// </summary>
        string AccountMemo { get; }

        /// <summary>
        /// The duration in which it will automatically extend the expiration period. If it doesn't have
        /// enough balance, it extends as long as possible. If it is empty when it expires, then it is
        /// deleted.
        ///
        /// Defaults to 90 days (or 7,776,000 seconds).
        /// </summary>
        TimeSpan AutoRenewPeriod { get; }

        /// <summary>
        /// If true, the account declines receiving a staking reward. The default value is false.
        /// </summary>
        bool? DeclineStakingReward { get; }

        /// <summary>
        /// The new expiration time to extend to (ignored if equal to or before the current one)
        /// </summary>
        DateTimeOffset ExpirationTime { get; }

        /// <summary>
        /// The new key.
        ///
        /// This is the key that must sign each transfer out of the account.
        ///
        /// If `receiverSignatureRequired` is true, then the key must also sign
        /// any transfer into the account.
        /// </summary>
        IKey Key { get; }

        /// <summary>
        /// The maximum number of tokens that an Account can be implicitly associated with. Up to a 1000
        /// including implicit and explicit associations.
        /// </summary>
        long MaxAutomaticTokenAssociations { get; }

        /// <summary>
        /// Deprecated: with no replacement
        ///
        /// ID of the account to which this account is proxy staked. If proxyAccountID is null, or is an
        /// invalid account, or is an account that isn't a node, then this account is automatically proxy
        /// staked to a node chosen by the network, but without earning payments. If the proxyAccountID
        /// account refuses to accept proxy staking , or if it is not currently running a node, then it
        /// will behave as if proxyAccountID was null.
        /// </summary>
        AccountId ProxyAccountId { get; }

        /// <summary>
        /// If true, this account's key must sign any transaction depositing
        /// into this account (in addition to all withdrawals).
        ///
        /// Defaults to `false`.
        /// </summary>
        bool ReceiverSignatureRequired { get; }

        /// <summary>
        /// ID of the account to which this contract is staking.
        /// </summary>
        AccountId? StakedNodeAccountId { get; }

        /// <summary>
        /// ID of the node this contract is staked to.
        /// </summary>
        long? StakedNodeId { get; }
    }
}
