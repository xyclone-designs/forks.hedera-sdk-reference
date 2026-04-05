/// <summary>
/// &gt; class `ContractCallQuery` extends [`Query`](reference/core/Query.md) &lt; [`ContractFunctionResult`](reference/contract/ContractFunctionResult.md) &gt;
/// Retrieve the latest state of a contract call.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var callQuery = new ContractCallQuery()
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .setContractId(contractId)
/// .setGas(2000)
/// .setFunction("getMessage");
/// var cost = callQuery.getCost(client);
/// var result = callQuery
/// .setMaxQueryPayment(Objects.requireNonNull(cost))
/// .execute(client);
/// ```
/// ```javascript
/// const callQuery = new ContractCallQuery()
/// .setNodeAccountIds([response.nodeId])
/// .setContractId(contract)
/// .setQueryPayment(new Hbar(1))
/// .setGas(2000)
/// .setFunction("getMessage");
/// const cost = callQuery.getCost(client);
/// let result = await callQuery
/// .setMaxQueryPayment(cost)
/// .execute(client);
/// ```
/// ```go
/// result, err := hedera.NewContractCallQuery().
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// SetContractID(contractID).
/// SetQueryPayment(NewHbar(1)).
/// SetGas(2000).
/// SetFunction("getMessage", nil).
/// SetMaxQueryPayment(NewHbar(5)).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// --
/// --
/// `Function`: `ContractCallQuery`
/// The `ContractId` for which information is being requested.
/// --
/// The amount of gas to use for the call.
/// All of the gas offered will be used and charged a corresponding fee.
/// --
/// Which function to call, and the parameters to pass to the function. Use
/// [`setFunction(name)`](#setfunction-name-string-contractcallquery) and
/// [`setFunction(name, params)`](#setfunction-name-string-params-contractfunctionparameters-contractcallquery)
/// to set this field.
/// --
/// Maximum number of bytes that the result might include. The run will fail if it is returning more than this number of bytes.
/// --
/// </summary>
public interface IContractCallQuery
{
}