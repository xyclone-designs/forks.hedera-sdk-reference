/// <summary>
/// &gt; class `FileInfoQuery` extends [`Query`](reference/core/Query.md) &lt; [`FileInfo`](reference/file/FileInfo.md) &gt;
/// Query a file's current state.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var info = new FileInfoQuery()
/// .setFileId(fileId)
/// .execute(client) // ByteString
/// ```
/// ```javascript
/// const info = await new FileInfoQuery({ fileId }).execute(client); // Uint8Array
/// ```
/// ```go
/// info, err := hedera.NewFileInfoQuery().
/// SetFileID(fileID).
/// Execute(client) // []byte
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// This is the file ID for which info will be queried for.
/// --
/// </summary>
public interface IFileInfoQuery
{
}