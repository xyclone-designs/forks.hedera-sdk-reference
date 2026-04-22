using Hedera.Hashgraph.Reference.Cryptocurrency;

using System;

namespace Hedera.Hashgraph.Reference
{
    public interface IStakingInfo
    {
        /// <summary>
        /// If true, this account or contract declined to receive a staking reward.
        /// </summary>
        bool DeclineStakingReward { get; }
        /// <summary>
        /// The staking period during which either the staking settings for this account or contract changed (such as starting
        /// staking or changing staked\_node\_id) or the most recent reward was earned, whichever is later.If this account or contract
        /// is not currently staked to a node, then this field is not set.
        /// </summary>
        DateTimeOffset StakePeriodStart { get; }
        /// <summary>
        /// The amount in tinybars that will be received in the next reward situation.
        /// </summary>
        IHbar PendingReward { get; }
        /// <summary>
        /// The total of balance of all accounts staked to this account or contract.
        /// </summary>
        IHbar StakedToMe { get; }
        /// <summary>
        /// The account to which this account or contract is staking.
        /// </summary>
        IAccountId? StakedAccountId { get; }
        /// <summary>
        /// The ID of the node this account or contract is staked to.
        /// </summary>
        long? StakedNodeId { get; }

        /// <summary>
        /// Serialize the [`StakingInfo`](#) into its protobuf representation.
        /// </summary>
        abstract byte[] ToBytes();
    }
    public interface IStakingInfo<TSelf> : IStakingInfo where TSelf : IStakingInfo<TSelf>
    {
        abstract static TSelf CTOR(bool declineStakingReward, DateTimeOffset stakePeriodStart, IHbar pendingReward, IHbar stakedToMe, IAccountId? stakedAccountId, long? stakedNodeId);

        /// <summary>
        /// Deserialize a [`StakingInfo`](#) from its the protobuf representation.
        /// </summary>
        abstract static TSelf FromBytes(byte[] data);        
    }
}
