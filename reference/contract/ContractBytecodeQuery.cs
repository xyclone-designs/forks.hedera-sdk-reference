/// <summary>
/// &gt; class `ContractByteCodeQuery` extends [`Query`](reference/core/Query.md) &lt; `bytes` &gt;
/// Retrieve the latest state of a bytecode.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var bytecode = new ContractByteCodeQuery()
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .setContractId(contractId)
/// .execute(client);
/// ```
/// ```javascript
/// const bytecode = await new ContractByteCodeQuery()
/// .setNodeAccountIds([response.nodeId])
/// .setContractId(contract)
/// .setQueryPayment(new Hbar(2))
/// .execute(client);
/// ```
/// ```go
/// bytecode, err := hedera.NewContractBytecodeQuery().
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// SetContractID(contractID).
/// SetQueryPayment(NewHbar(2)).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// This is the contract ID which bytecode will be queried for.
/// --
/// </summary>
public interface IContractBytecodeQuery
{
}