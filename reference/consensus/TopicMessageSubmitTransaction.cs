/// <summary>
/// &gt; class `TopicSubmitTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new TopicMessageSubmitTransaction()
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .setTopicId(topicId)
/// .setMessage("Hello, from HCS!")
/// .execute(client)
/// .getReceipt(client);
/// ```
/// ```js
/// await (
/// await new TopicMessageSubmitTransaction()
/// .setTopicId(topic)
/// .setMessage(contents)
/// .execute(client)
/// ).getReceipt(client);
/// ```
/// ```go
/// response, err := hedera.NewTopicMessageSubmitTransaction().
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// SetMessage([]byte(Contents)).
/// SetTopicID(topicID).
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
/// Topic to submit message to.
/// --
/// Message to be submitted. Max size of the Transaction (including signatures) is 6KiB.
/// --
/// </summary>
public interface ITopicMessageSubmitTransaction
{
}