/// <summary>
/// &gt; class `FileDeleteTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// Delete a file that exists on the Hedera Hashgraph network.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var receipt = new FileDeleteTransaction()
/// .setFileId(fileId)
/// .execute(client) // TransactionResponse
/// .getReceipt(client); // TransactionReceipt
/// ```
/// ```javascript
/// const receipt = await (
/// await new FileDeleteTransaction({ fileId }).execute(client)
/// ).getReceipt(client);
/// ```
/// ```go
/// response, err := NewFileDeleteTransaction().
/// SetFileID(fileID).
/// Execute(client) // TransactionResponse
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
/// This is the ID of the file to delete.
/// --
/// </summary>
public interface IFileDeleteTransaction
{
}