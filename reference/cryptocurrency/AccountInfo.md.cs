using Hedera.Hashgraph.Reference.Cryptography;
using Hedera.Hashgraph.Reference.LiveHash;
using Hedera.Hashgraph.Reference.Token;

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Hedera.Hashgraph.Reference.Cryptocurrency
{
    /// <summary>
    /// Info about the account (a state proof can be generated for this)
    /// </summary>
    public interface IAccountInfo
    {
        /// <summary>
        /// Serialize the [`AccountInfo`](AccountInfo) into its protobuf representation.
        /// </summary>
        byte[] ToBytes();

        /// <summary>
        /// The account ID for which this information applies
        /// </summary>
        IAccountId AccountId { get; }
        /// <summary>
        /// The memo associated with the account
        /// </summary>
        string AccountMemo { get; }
        /// <summary>
        /// The alias of this account
        /// </summary>
        IPublicKey? AliasKey { get; }
        /// <summary>
        /// The duration for expiration time will extend every this many seconds. If there are
        /// insufficient funds, then it extends as long as possible. If it is empty when it expires,
        /// then it is deleted.
        ///
        /// Defaults to 90 days (or 7,776,000 seconds).
        /// </summary>
        TimeSpan AutoRenewPeriod { get; }
        /// <summary>
        /// The current balance of account in tinybars
        /// </summary>
        IHbar Balance { get; }
        /// <summary>
        /// The Contract Account ID comprising both the contract instance and the cryptocurrency
        /// account owned by the contract instance, in the format used by Solidity
        /// </summary>
        string ContractAccountId { get; }
        /// <summary>
        /// The ethereum transaction nonce associated with this account.
        /// </summary>
        long EthereumNonce { get; }
        /// <summary>
        /// The TimeStamp time at which this account is set to expire.
        /// </summary>
        DateTimeOffset ExpirationTime { get; }
        /// <summary>
        /// All IHbar allowances approved by the account owner.
        /// </summary>
        IList<IHbarAllowance> IHbarAllowances { get; }
        /// <summary>
        /// If true, then this account has been deleted, it will disappear when it expires, and all
        /// transactions for it will fail except the transaction to extend its expiration date
        /// </summary>
        bool IsDeleted { get; }
        /// <summary>
        /// If true, no transaction can transfer to this account unless signed by this account's key.
        /// </summary>
        bool IsReceiverSignatureRequired { get; }
        /// <summary>
        /// The key for the account, which must sign in order to transfer out, or to modify the
        /// account in any way other than extending its expiration date.
        /// </summary>
        IKey IKey { get; }
        /// <summary>
        /// The ID of the ledger which returned this response
        /// </summary>
        ILedgerId LedgerId { get; }
        /// <summary>
        /// All livehashes attached to the account (each of which is a hash along with the
        /// keys that authorized it and can delete it);
        /// </summary>
        ILiveHash[] LiveHashes { get; }
        /// <summary>
        /// The maximum number of tokens that an Account can be implicitly associated with.
        /// </summary>
        long MaxAutomaticTokenAssociations { get; }
        /// <summary>
        /// The number of NFTs owned by this account
        /// </summary>
        long OwnedNfts { get; }
        /// <summary>
        /// Deprecated: with no replacement
        ///
        /// The Account ID of the account to which this is proxy staked. If proxyAccountID is null,
        /// or is an invalid account, or is an account that isn't a node, then this account is
        /// automatically proxy staked to a node chosen by the network, but without earning payments.
        /// If the proxyAccountID account refuses to accept proxy staking , or if it is not currently
        /// running a node, then it will behave as if proxyAccountID was null.
        /// </summary>
        IAccountId? ProxyAccountId { get; }
        /// <summary>
        /// The total number of tinybars proxy staked to this account
        /// </summary>
        IHbar ProxyReceived { get; }
        /// <summary>
        /// The threshold amount for which an account record is created (and this account charged
        /// for them) for any transaction above this amount.
        /// </summary>
        IHbar ReceiveRecordThreshold { get; }
        /// <summary>
        /// The threshold amount for which an account record is created (and this account charged
        /// for them) for any send/withdraw transaction.
        /// </summary>
        IHbar SendRecordThreshold { get; }
        /// <summary>
        /// Staking metadata for this contract.
        /// </summary>
        IStakingInfo? StakingInfo { get; }
        /// <summary>
        /// All fungible token allowances approved by the account owner.
        /// </summary>
        IList<ITokenAllowance> TokenAllowances { get; }
        /// <summary>
        /// All non-fungible token allowances approved by the account owner.
        /// </summary>
        IList<ITokenNftAllowance> TokenNftAllowances { get; }
        /// <summary>
        /// All tokens related to this account.
        /// </summary>
        IDictionary<ITokenId, ITokenRelationship> TokenRelationships { get; }
    }
    public interface IAccountInfo<TSelf> : IAccountInfo where TSelf : IAccountInfo<TSelf>
    {
        abstract static TSelf CTOR(
            IAccountId accountId,
            string contractAccountId,
            bool isDeleted,
            IAccountId? proxyAccountId,
            IHbar proxyReceived,
            IKey key,
            IHbar balance,
            IHbar sendRecordThreshold,
            IHbar receiveRecordThreshold,
            bool receiverSignatureRequired,
            DateTimeOffset expirationTime,
            TimeSpan autoRenewPeriod,
            IEnumerable<ILiveHash> liveHashes,
            IDictionary<ITokenId, ITokenRelationship> tokenRelationships,
            string accountMemo,
            long ownedNfts,
            int maxAutomaticTokenAssociations,
            IPublicKey? aliasKey,
            ILedgerId ledgerId,
            long ethereumNonce,
            IStakingInfo? stakingInfo);

        /// <summary>
        /// Deserialize a [`AccountInfo`](AccountInfo) from its protobuf representation.
        /// </summary>
        abstract static TSelf FromBytes(byte[] data);
    }
}
