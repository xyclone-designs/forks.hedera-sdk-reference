/// <summary>
/// &gt; class `TopicMessageQuery`
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var handle = new TopicMessageQuery()
/// .setTopicId(topicId)
/// .setStartTime(Instant.EPOCH)
/// .subscribe(client, (message) -&gt; {
/// receivedMessage[0] = new String(message.contents, StandardCharsets.UTF_8).equals("Hello, from HCS!");
/// });
/// ```
/// ```javascript
/// const handle = new TopicMessageQuery()
/// .setTopicId(topic)
/// .setStartTime(0)
/// .subscribe(client, (message) =&gt; {
/// received = utf8.decode(message.contents) === contents;
/// });
/// ```
/// ```go
/// handle, err = hedera.NewTopicMessageQuery().
/// SetTopicID(topicID).
/// SetStartTime(time.Unix(0, 0)).
/// Subscribe(client, func(message TopicMessage) {
/// if string(message.Contents) == bigContents {
/// wait = false
/// }
/// })
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// The ID for a topic to subscribe to.
/// --
/// </summary>
public interface ITopicMessageQuery
{
}