/// <summary>
/// &gt; class `TopicUpdateTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// &lt;details&gt;
/// &lt;summary&gt;&lt;b&gt;Table of Contents&lt;/b&gt;&lt;/summary&gt;
/// | Item | Java | JavaScript | Go
/// | - | - | - | - |
/// | [`topicId`](#topicid-topicid) | ✅ | ✅ | ✅
/// | [`adminKey`](#adminkey-key) | ✅ | ✅ | ✅
/// | [`submitKey`](#submitkey-key) | ✅ | ✅ | ✅
/// | [`autoRenewPeriod`](#autorenewperiod-duration) | ✅ | ✅ | ✅
/// | [`autoRenewAccountId`](#autorenewaccountid-accountid) | ✅ | ✅ | ✅
/// | [`topicMemo`](#topicmemo-string) | ✅ | ✅ | ✅
/// &lt;/details&gt;
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new TopicUpdateTransaction()
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .setTopicId(TopicId.fromString("0.0.5007"))
/// .execute(client)
/// .getReceipt(client)
/// ```
/// ```js
/// await(
/// await new TopicUpdateTransaction()
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .setTopicId(TopicId.fromString("0.0.5007"))
/// .execute(client)
/// ).getReceipt(client)
/// ```
/// ```go
/// response, err := hedera.NewTopicUpdateTransaction().
/// SetTopicID(topicID).
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// SetTopicMemo(newTopicMemo).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// receipt, err := response.GetReceipt(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// Clear the memo for this topic.
/// --
/// Clear the admin key.
/// Note: Clearing the admin key will make the topic immutable.
/// --
/// Clear the submit key.
/// --
/// Clear the auto renew account ID.
/// --
/// `TopicId` to be updated.
/// --
/// Access control for update/delete of the topic.
/// If unspecified, no change.
/// If empty `keyList` - the `adminKey` is cleared.
/// --
/// Access control for `submitMessage`.
/// If unspecified, no change.
/// If empty `keyList` - the `submitKey` is cleared.
/// --
/// The amount of time to extend the topic's lifetime automatically at `expirationTime` if the `autoRenewAccountId` is
/// configured and has funds.
/// --
/// Optional account to be used at the topic's `expirationTime` to extend the life of the topic.
/// If specified as the default value (0.0.0), the `autoRenewAccountId` will be removed.
/// If unspecified, no change.
/// --
/// Short publicly visible memo about the topic. No guarantee of uniqueness. Null for "do not update".
/// --
/// </summary>
public interface ITopicUpdateTransaction
{
}