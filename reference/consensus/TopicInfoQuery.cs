/// <summary>
/// &gt; class `TopicInfoQuery` extends [`Query`](reference/core/Query.md) &lt; [`TopicInfo`](reference/consensus/TopicInfo.md) &gt;
/// Retrieve the latest state of a topic.
/// This method is unrestricted and allowed on any topic by any payer account.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var info = new TopicInfoQuery()
/// .setTopicId(topicId)
/// .execute(client)
/// ```
/// ```javascript
/// const info = await new TopicInfoQuery({ topicId }).execute(client); // Uint8Array
/// ```
/// ```go
/// info, err := hedera.NewTopicInfoQuery().
/// SetTopicID(topicID).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// This is the topic ID for which info will be queried for.
/// </summary>
public interface ITopicInfoQuery
{
}