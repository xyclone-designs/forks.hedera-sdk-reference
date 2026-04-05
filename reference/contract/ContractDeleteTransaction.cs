/// <summary>
/// &gt; class `ContractDeleteTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new ContractDeleteTransaction()
/// .setContractId(contractId)
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .execute(client)
/// .getReceipt(client);
/// ```
/// ```js
/// await (
/// await new ContractDeleteTransaction()
/// .setContractId(contract)
/// .setNodeAccountIds([response.nodeId])
/// .execute(client)
/// ).getReceipt(client);
/// ```
/// ```go
/// response, err := hedera.NewContractDeleteTransaction().
/// SetContractID(contractID).
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
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
/// The ID of the contract to be deleted.
/// --
/// The ID of an account that will receive any remaining `Hbar` from the deleted contract.
/// --
/// The ID of a contract that will receive any remaining `Hbar` from the deleted contract
/// --
/// </summary>
public interface IContractDeleteTransaction
{
}