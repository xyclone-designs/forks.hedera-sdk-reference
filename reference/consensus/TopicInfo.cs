/// <summary>
/// &gt; class `TopicInfo`
/// Current state of the topic
/// Deserialize a [`TopicInfo`](#) from its the protobuf representation.
/// --
/// Serialize the [`TopicInfo`](#) into its protobuf representation.
/// --
/// The ID for which this info belongs to.
/// --
/// The memo set on the topic.
/// --
/// The current running hash of the last topic message.
/// --
/// The sequence number of the last topic message.
/// --
/// The timestamp when this topic will expire which will effectively delete this topic.
/// --
/// The key that is required to sign transactions that mutate this topic.
/// --
/// The key that is required to sign transactions that submit messages to this topic.
/// --
/// The duration since topic creation when this topic will be auto renewed and the auto renew account will be charged.
/// --
/// The auto renew account that will be charged when the topic is to be auto renewed.
/// --
/// The ID of the ledger which returned this response
/// --
/// </summary>
public interface ITopicInfo
{
}