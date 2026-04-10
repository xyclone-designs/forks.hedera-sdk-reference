using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;
using Hedera.Hashgraph.Reference.Token;

using System;
using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Contract
{
    /// <summary>
    /// Current information on the smart contract instance, including its balance.
    /// </summary>
    public class ContractInfo
    {
        public ContractInfo(
            ContractId contractId,
            AccountId accountId,
            string contractAccountId,
            IKey? adminKey,
            DateTimeOffset expirationTime,
            TimeSpan autoRenewPeriod,
            AccountId autoRenewAccountId,
            long storage,
            string contractMemo,
            Hbar balance,
            bool isDeleted,
            IDictionary<TokenId, TokenRelationship> tokenRelationships,
            LedgerId ledgerId,
            StakingInfo stakingInfo)
        {
            ContractId = contractId;
            AccountId = accountId;
            ContractAccountId = contractAccountId;
            AdminKey = adminKey;
            ExpirationTime = expirationTime;
            AutoRenewPeriod = autoRenewPeriod;
            AutoRenewAccountId = autoRenewAccountId;
            Storage = storage;
            ContractMemo = contractMemo;
            Balance = balance;
            IsDeleted = isDeleted;
            TokenRelationships = tokenRelationships;
            LedgerId = ledgerId;
            StakingInfo = stakingInfo;
        }

        /// <summary>
        /// Deserialize a [`ContractInfo`](ContractInfo) from its protobuf representation.
        /// </summary>
        public static ContractInfo FromBytes(byte[] data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serialize the [`ContractInfo`](ContractInfo) into its protobuf representation.
        /// </summary>
        public virtual byte[] ToBytes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ID of the cryptocurrency account owned by the contract instance.
        /// </summary>
        public AccountId AccountId { get; }
        /// <summary>
        /// The state of the instance and its fields can be modified arbitrarily if `adminKey` signs a transaction to modify it.
        /// If this is null, then such modifications are not possible, and there is no administrator that can override the normal operation of this smart contract instance.
        /// Note that if it is created with no admin keys, then there is no administrator to authorize changing the admin keys, so there can never be any admin keys for that instance.
        /// </summary>
        public IKey? AdminKey { get; }
        /// <summary>
        /// ID of the account to charge for auto-renewal of this contract.
        /// </summary>
        public AccountId AutoRenewAccountId { get; }
        /// <summary>
        /// The expiration time will extend every this many seconds.
        /// If there are insufficient funds, then it extends as long as possible.
        /// If the account is empty when it expires, then it is deleted.
        /// </summary>
        public TimeSpan AutoRenewPeriod { get; }
        /// <summary>
        /// The current balance, in tinybars.
        /// </summary>
        public Hbar Balance { get; }
        /// <summary>
        /// ID of both the contract instance and the cryptocurrency account owned by the contract instance, in the format used by Solidity.
        /// </summary>
        public string ContractAccountId { get; }
        /// <summary>
        /// ID of the contract instance.
        /// </summary>
        public ContractId ContractId { get; }
        /// <summary>
        /// The memo associated with the contract (max 100 bytes).
        /// </summary>
        public string ContractMemo { get; }
        /// <summary>
        /// The current time at which this contract instance (and its account) is set to expire.
        /// </summary>
        public DateTimeOffset ExpirationTime { get; }
        /// <summary>
        /// Whether the contract has been deleted.
        /// </summary>
        public bool IsDeleted { get; }
        /// <summary>
        /// The ID of the ledger which returned this response
        /// </summary>
        public LedgerId LedgerId { get; }
        /// <summary>
        /// Staking metadata for this contract.
        /// </summary>
        public StakingInfo StakingInfo { get; }
        /// <summary>
        /// Number of bytes of storage being used by this instance (which affects the cost to extend the expiration time).
        /// </summary>
        public long Storage { get; }
        /// <summary>
        /// The tokens associated to the contract.
        /// </summary>
        public IDictionary<TokenId, TokenRelationship> TokenRelationships { get; }
    }
}
