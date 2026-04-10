using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;
using Hedera.Hashgraph.Reference.File;

using System;

namespace Hedera.Hashgraph.Reference.Contract
{
    public interface IContractUpdateTransaction : ITransaction
    {
        /// <summary>
        /// The id of the contract to be updated.
        /// </summary>
        ContractId ContractId { get; }
        /// <summary>
        /// The new key to control updates/deletion of the contract.
        /// </summary>
        Key AdminKey { get; }
        /// <summary>
        /// The new expiry of the contract, no earlier than the current expiry.
        /// </summary>
        DateTimeOffset ExpirationTime { get; }
        /// <summary>
        /// Deprecated: with no replacement
        /// ***Not yet implemented***
        /// <br>
        /// The new id of the account to which the contract is proxy staked.
        /// </summary>
        AccountId ProxyAccountId { get; }
        /// <summary>
        /// ***Not yet implemented***
        /// <br>
        /// The new interval at which the contract will pay to extend its expiry.
        /// </summary>
        TimeSpan AutoRenewPeriod { get; }
        /// <summary>
        /// The new id of the file asserted to contain the bytecode of the Solidity transaction that created this contract.
        /// </summary>
        FileId BytecodeFileId { get; }
        /// <summary>
        /// The new contract memo, assumed to be Unicode encoded with UTF-8 (at most 100 bytes).
        /// </summary>
        string ContractMemo { get; }
        /// <summary>
        /// ID of the account to which this contract is staking.
        /// </summary>
        AccountId? StakedNodeAccountId { get; }
        /// <summary>
        /// ID of the node this contract is staked to.
        /// </summary>
        long? StakedNodeId { get; }
        /// <summary>
        /// If true, the contract declines receiving a staking reward. The default value is false.
        /// </summary>
        bool? DeclineStakingReward { get; }
    }
}
