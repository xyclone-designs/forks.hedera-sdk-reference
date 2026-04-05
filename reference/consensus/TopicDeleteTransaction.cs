/// <summary>
/// &gt; class `TopicDeleteTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new TopicDeleteTransaction()
/// .setTopicId(topicId)
/// .execute(client)
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .getReceipt(client);
/// ```
/// ```js
/// await (
/// await new TopicDeleteTransaction().setTopicId(topic).execute(client)
/// ).getReceipt(client);
/// ```
/// ```go
/// response, err = hedera.NewTopicDeleteTransaction().
/// SetTopicID(topicID).
/// SetNodeAccountIDs([]AccountID{response.NodeID}).
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
/// The `topicId` which should be deleted
/// --
/// </summary>
public interface ITopicDeleteTransaction
{
}