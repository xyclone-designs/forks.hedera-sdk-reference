/// <summary>
/// &gt; class `SystemDeleteTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// Delete a file or smart contract - can only be done with a Hedera administrative multisignature.
/// When it is deleted, it immediately disappears from the system as seen by the user, but is still
/// stored internally until the expiration time, at which time it is truly and permanently deleted.
/// Until that time, it can be undeleted by the Hedera administrative multisignature. When a smart
/// contract is deleted, the cryptocurrency account within it continues to exist, and is not affected
/// by the expiration time here.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new SystemDeleteTransaction()
/// .setContractId(new ContractId(10))
/// .setExpirationTime(Instant.now())
/// .execute(client);
/// new SystemDeleteTransaction()
/// .setFileId(new FileId(10))
/// .setExpirationTime(Instant.now())
/// .execute(client);
/// ```
/// ```js
/// await new SystemDeleteTransaction()
/// .setContractId(new ContractId(10))
/// .setExpirationTime(Timestamp.generate())
/// .execute(client);
/// await new SystemDeleteTransaction()
/// .setFileId(new FileId(10))
/// .setExpirationTime(Timestamp.generate())
/// .execute(client);
/// ```
/// ```go
/// response, err = hedera.NewSystemDeleteTransaction().
/// SetFileID(FileIDFromString("0.0.3").
/// SetExpirationTime(time.Now().Local().Add(time.Second * 5)).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// receipt, err := response.GetReceipt(client)
/// if err != nil {
/// println(err.Error())
/// }
/// response, err = hedera.NewSystemDeleteTransaction().
/// SetContractID(ContractIDFromString("0.0.3").
/// SetExpirationTime(time.Now().Local().Add(time.Second * 5)).
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
/// --
/// </summary>
public interface ISystemDeleteTransaction
{
}