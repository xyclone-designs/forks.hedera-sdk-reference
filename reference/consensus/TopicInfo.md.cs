using Google.Protobuf;
using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;

using System;
using System.Data;

namespace Hedera.Hashgraph.Reference.Consensus
{
    /// <summary>
    /// Current state of the topic
    /// </summary>
    public class TopicInfo
    {
        public TopicInfo(TopicId topicId, string topicMemo, byte[] runningHash, ulong sequenceNumber, DateTimeOffset expirationTime, IKey? adminKey, IKey? submitKey, TimeSpan autoRenewPeriod, AccountId autoRenewAccountId, LedgerId ledgerId)
        {
            TopicId = topicId;
            TopicMemo = topicMemo;
            RunningHash = runningHash;
            SequenceNumber = sequenceNumber;
            ExpirationTime = expirationTime;
            AdminKey = adminKey;
            SubmitKey = submitKey;
            AutoRenewPeriod = autoRenewPeriod;
            AutoRenewAccountId = autoRenewAccountId;
            LedgerId = ledgerId;
        }

        /// <summary>
        /// Deserialize a [`TopicInfo`](#) from its the protobuf representation.
        /// </summary>
        public static TopicInfo FromBytes(byte[] data)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Serialize the [`TopicInfo`](#) into its protobuf representation.
        /// </summary>
        public virtual byte[] ToBytes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The ID for which this info belongs to.
        /// </summary>
        public TopicId TopicId { get; }
        /// <summary>
        /// The memo set on the topic.
        /// </summary>
        public string TopicMemo { get; }
        /// <summary>
        /// The current running hash of the last topic message.
        /// </summary>
        public byte[] RunningHash { get; }
        /// <summary>
        /// The sequence number of the last topic message.
        /// </summary>
        public ulong SequenceNumber { get; }
        /// <summary>
        /// The timestamp when this topic will expire which will effectively delete this topic.
        /// </summary>
        public DateTimeOffset ExpirationTime { get; }
        /// <summary>
        /// The key that is required to sign transactions that mutate this topic.
        /// </summary>
        public IKey? AdminKey { get; }
        /// <summary>
        /// The key that is required to sign transactions that submit messages to this topic.
        /// </summary>
        public IKey? SubmitKey { get; }
        /// <summary>
        /// The duration since topic creation when this topic will be auto renewed and the auto renew account will be charged.
        /// </summary>
        public TimeSpan AutoRenewPeriod { get; }
        /// <summary>
        /// The auto renew account that will be charged when the topic is to be auto renewed.
        /// </summary>
        public AccountId AutoRenewAccountId { get; }
        /// <summary>
        /// The ID of the ledger which returned this response
        /// </summary>
        public LedgerId LedgerId { get; }
    }
}
