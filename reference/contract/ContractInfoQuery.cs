/// <summary>
/// &gt; class `ContractInfoQuery` extends [`Query`](reference/core/Query.md) &lt; [`ContractInfo`](reference/contract/ContractInfo.md) &gt;
/// Retrieve the latest state of a contract.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var info = new ContractInfoQuery()
/// .setContractId(contractId)
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .execute(client);
/// ```
/// ```javascript
/// let info = await new ContractInfoQuery()
/// .setNodeAccountIds([response.nodeId])
/// .setContractId(contract)
/// .setQueryPayment(new Hbar(1))
/// .execute(client);
/// ```
/// ```go
/// info, err := hedera.NewContractInfoQuery().
/// SetContractID(contractID).
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// SetMaxQueryPayment(NewHbar(2)).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// This is the contractc ID for which info will be queried for.
/// --
/// </summary>
public interface IContractInfoQuery
{
}