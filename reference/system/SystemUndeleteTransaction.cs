/// <summary>
/// &gt; class `SystemUndeleteTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// Undelete a file or smart contract that was deleted by SystemDelete; requires a Hedera
/// administrative multisignature.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new SystemUndeleteTransaction()
/// .setContractId(new ContractId(10))
/// .setExpirationTime(Instant.now())
/// .execute(client);
/// new SystemUndeleteTransaction()
/// .setFileId(new FileId(10))
/// .setExpirationTime(Instant.now())
/// .execute(client);
/// ```
/// ```js
/// await new SystemUndeleteTransaction()
/// .setContractId(new ContractId(10))
/// .setExpirationTime(Timestamp.generate())
/// .execute(client);
/// await new SystemUndeleteTransaction()
/// .setFileId(new FileId(10))
/// .setExpirationTime(Timestamp.generate())
/// .execute(client);
/// ```
/// ```go
/// response, err = hedera.NewSystemUndeleteTransaction().
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
/// response, err = hedera.NewSystemUndeleteTransaction().
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
public interface ISystemUndeleteTransaction
{
}