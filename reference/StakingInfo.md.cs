using Hedera.Hashgraph.Reference.Cryptocurrency;

using System;

namespace Hedera.Hashgraph.Reference
{
    public abstract class StakingInfo(bool declineStakingReward, DateTimeOffset stakePeriodStart, Hbar pendingReward, Hbar stakedToMe, AccountId? stakedAccountId, long? stakedNodeId)
    {
        /// <summary>
        /// Deserialize a [`StakingInfo`](#) from its the protobuf representation.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static StakingInfo FromBytes(byte[] data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serialize the [`StakingInfo`](#) into its protobuf representation.
        /// </summary>
        public abstract byte[] ToBytes();

        /// <summary>
        /// If true, this account or contract declined to receive a staking reward.
        /// </summary>
        public bool DeclineStakingReward { get; } = declineStakingReward;
        /// <summary>
        /// The staking period during which either the staking settings for this account or contract changed (such as starting
        /// staking or changing staked\_node\_id) or the most recent reward was earned, whichever is later.If this account or contract
        /// is not currently staked to a node, then this field is not set.
        /// </summary>
        public DateTimeOffset StakePeriodStart { get; } = stakePeriodStart;
        /// <summary>
        /// The amount in tinybars that will be received in the next reward situation.
        /// </summary>
        public Hbar PendingReward { get; } = pendingReward;
        /// <summary>
        /// The total of balance of all accounts staked to this account or contract.
        /// </summary>
        public Hbar StakedToMe { get; } = stakedToMe;
        /// <summary>
        /// The account to which this account or contract is staking.
        /// </summary>
        public AccountId? StakedAccountId { get; } = stakedAccountId;
        /// <summary>
        /// The ID of the node this account or contract is staked to.
        /// </summary>
        public long? StakedNodeId { get; } = stakedNodeId;
    }
}
