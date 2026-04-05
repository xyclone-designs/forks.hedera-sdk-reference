/// <summary>
/// &gt; class `FileContentsQuery` extends [`Query`](reference/core/Query.md) &lt; `bytes` &gt;
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var contents = new FileContentsQuery()
/// .setFileId(fileId)
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .execute(client);
/// ```
/// ```javascript
/// const contents = await new FileContentsQuery()
/// .setFileId(file)
/// .setNodeAccountIds([response.nodeId])
/// .setMaxQueryPayment(new Hbar(1))
/// .execute(client);
/// ```
/// ```go
/// contents, err := NewFileContentsQuery().
/// SetFileID(*fileID).
/// SetMaxQueryPayment(NewHbar(1)).
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// Execute(client) //[]byte
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// This is the fileID which contents queried for.
/// --
/// </summary>
public interface IFileContentsQuery
{
}