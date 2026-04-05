/// <summary>
/// &gt; class `LiveHashAddTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new LiveHashAddTransaction()
/// .setTopicId(topicId)
/// .execute(client)
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .getReceipt(client);
/// ```
/// ```js
/// await (
/// await new LiveHashAddTransaction().setTopicId(topic).execute(client)
/// ).getReceipt(client);
/// ```
/// ```go
/// response, err = hedera.NewLiveHashAddTransaction().
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
/// --
/// --
/// </summary>
public interface ILiveHashDeleteTransaction
{
}