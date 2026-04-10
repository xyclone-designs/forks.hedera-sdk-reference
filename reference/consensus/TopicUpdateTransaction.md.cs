using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;

using System;

namespace Hedera.Hashgraph.Reference.Consensus
{
    public interface ITopicUpdateTransaction : ITransaction
    {
        /// <summary>
        /// Clear the memo for this topic.
        /// </summary>
        void ClearTopicMemo();

        /// <summary>
        /// Clear the admin key.
        /// Note: Clearing the admin key will make the topic immutable.
        /// </summary>
        void ClearAdminKey();

        /// <summary>
        /// Clear the submit key.
        /// </summary>
        void ClearSubmitKey();

        /// <summary>
        /// Clear the auto renew account ID.
        /// </summary>
        void ClearAutoRenewAccountId();

        /// <summary>
        /// `TopicId` to be updated.
        /// </summary>
        TopicId TopicId { get; }

        /// <summary>
        /// Access control for update/delete of the topic.
        /// If unspecified, no change.
        /// If empty `keyList` - the `adminKey` is cleared.
        /// </summary>
        Key AdminKey { get; }

        /// <summary>
        /// Access control for `submitMessage`.
        /// If unspecified, no change.
        /// If empty `keyList` - the `submitKey` is cleared.
        /// </summary>
        Key SubmitKey { get; }

        /// <summary>
        /// The amount of time to extend the topic's lifetime automatically at `expirationTime` if the `autoRenewAccountId` is
        /// configured and has funds.
        /// </summary>
        TimeSpan AutoRenewPeriod { get; }

        /// <summary>
        /// Optional account to be used at the topic's `expirationTime` to extend the life of the topic.
        /// If specified as the default value (0.0.0), the `autoRenewAccountId` will be removed.
        /// If unspecified, no change.
        /// </summary>
        AccountId AutoRenewAccountId { get; }

        /// <summary>
        /// Short publicly visible memo about the topic. No guarantee of uniqueness. Null for "do not update".
        /// </summary>
        string TopicMemo { get; }
    }
}
