/// <summary>
/// &gt; class `TopicMessage`
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var handle = new TopicMessageQuery()
/// .setTopicId(topicId)
/// .setStartTime(Instant.EPOCH)
/// .setErrorHandler((e /* Throwable */, message /* TopicMessage */) -&gt; {
/// System.err.println(e.getMessage());
/// if (message != null) {
/// System.err.println("Caused by message: " + new String(message.contents, StandardCharsets.UTF_8));
/// }
/// })
/// .subscribe(client, (message /* TopicMessage */) -&gt; {
/// System.out.println(new String(message.contents, StandardCharsets.UTF_8));
/// });
/// ```
/// ```javascript
/// const handle = new TopicMessageQuery({ topicId, startTime: 0 })
/// .setErrorHandler((error /* error */, message /* TopicMessage */) =&gt; {
/// console.err(error);
/// if (message != null) {
/// console.err(`Caused by message: ${utf8.decode(message.contents)}`);
/// }
/// })
/// .subscribe(client, (message /* TopicMessage */) =&gt; {
/// console.log(utf8.decode(message.contents));
/// });
/// ```
/// ```go
/// handle := hedera.NewTopicMessageQuery().
/// SetTopicID(topicID).
/// SetStartTime(0).
/// SetErrorHandler(func(err /* error */) {
/// panic(err)
/// })
/// Subscribe(client, func(message /* TopicMessage */) {
/// println(string(message.contents))
/// })
/// ```
/// &lt;!-- tabs:end --&gt;
/// The consensus timestamp of this topic message. If this message was chunked, this
/// field would be equal to the last chunk's consensus timestamp.
/// --
/// The contents of this topic message. If this message was chunked, this field would
/// be equal to the concatination of all the chunks.
/// --
/// The running hash of this topic message. If this message was chunked this field would
/// be equal to the last chunk's running hash.
/// --
/// The sequence number of this topic message. If this message was chunked this field would
/// be equal to the last chunk's sequence number.
/// --
/// The chunks of this topic message. Will be null if this topic message was not chunked.
/// Otherwise will contain an ordered list of chunks for this topic message.
/// --
/// </summary>
public interface ITopicMessage
{
}