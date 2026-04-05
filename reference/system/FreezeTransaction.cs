/// <summary>
/// &gt; class `FreezeTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// At consensus, sets the consensus time at which the platform should stop creating events and
/// accepting transactions, and enter a maintenance window.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new FreezeTransaction()
/// .setStartTime(Instant.now())
/// .setFileId(new FileId(10))
/// .setFileHash(fileHash)
/// .setFreezeType(FreezeType.FreezeUpgrade)
/// .execute(client)
/// .getReceipt(client);
/// ```
/// ```js
/// await(
/// await new FreezeTransaction()
/// .setStartTime(Date.now())
/// .setFileId(new FileId(10))
/// .setFileHash(fileHash)
/// .setFreezeType(FreezeType.FreezeUpgrade)
/// .execute(client)
/// ).getReceipt(client);
/// ```
/// ```go
/// response, err = hedera.NewSystemDeleteTransaction().
/// SetStartTime(time.Now()).
/// SetFileID(FileIDFromString("0.0.3")).
/// SetFileHash(fileHash).
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
/// Deprecated with no replacement
/// --
/// If set, the file whose contents should be used for a network software update during the maintenance
/// window.
/// --
/// If set, the expected hash of the contents of the update file (used to verify the update).
/// --
/// If set, the expected hash of the contents of the update file (used to verify the update).
/// --
/// </summary>
public interface IFreezeTransaction
{
}