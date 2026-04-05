/// <summary>
/// &gt; class `FileCreateTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var fileId = new FileCreateTransaction()
/// .setKeys(fileId)
/// .setContents("Initial contents of the file")
/// .execute(client) // TransactionResponse
/// .getReceipt(client) // TransactionReceipt
/// .fileId // Nullable&lt;FileId&gt;
/// ```
/// ```javascript
/// const transaction = new FileAppendTransaction({
/// keys: [ client.operatorPublicKey ],
/// contents: "Hello, world",
/// });
/// const response = await transaction.execute(client) // TransactionResponse;
/// const receipt = await response.getReceipt(client) // TransactionReceipt;
/// const fileId = receipt.fileId // Nullable&lt;FileId&gt;;
/// ```
/// ```go
/// response, err := NewFileCreateTransaction().
/// SetKeys(client.GetOperatorPublicKey())
/// Execute(client) // TransactionResponse
/// if err != nil {
/// println(err.Error())
/// }
/// receipt, err := response.GetReceipt(client) // TransactionReceipt
/// if err != nil {
/// println(err.Error())
/// }
/// fileId := receipt.FileId // Nullable&lt;FileID&gt;
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// This is the key that must sign when mutating the file via [`FileUpdateTransaction`](reference/file/FileUpdateTransaction.md)
/// or [`FileUpdateTransaction`](reference/file/FileUpdateTransaction.md) transactions.
/// If no key is provided the file is immutable any the aforementioned transactions will
/// err with status code [`UNAUTHORIZED`](reference/Status.md#UNAUTHORIZED).
/// --
/// These are the contents that will be set upon file creation. The contents cannot
/// exceed ~4096 bytes. Use [`FileAppendTransaction`](refernce/file/FileAppendTransaction.md)
/// to set larger contents.
/// **Note**. The setter `.setContents()` supports types `bytes` **and** UTF-8 `String`.
/// --
/// The expiration time of this file. After this time the file will be deleted. To
/// prevent file from being deleted a [`FileUpdateTransaction`](reference/file/FileUpdateTransaction.md) must be executed with a new expiration time.
/// `Timestmap` is the EPOCH seconds and nanoseconds of a future instant.
/// --
/// </summary>
public interface IFileCreateTransaction
{
}