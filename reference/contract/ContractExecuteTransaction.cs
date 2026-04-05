/// <summary>
/// &gt; class `ContractExecuteTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new ContractExecuteTransaction()
/// .setContractId(contractId)
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .setGas(10000)
/// .setFunction("setMessage", new ContractFunctionParameters().addString("new message"))
/// .execute(client)
/// .getReceipt(client);
/// ```
/// ```js
/// await (
/// await new ContractExecuteTransaction()
/// .setContractId(contract)
/// .setNodeAccountIds([response.nodeId])
/// .setGas(10000)
/// .setFunction(
/// "setMessage",
/// new ContractFunctionParameters().addString("new message")
/// )
/// .setMaxTransactionFee(new Hbar(5))
/// .execute(client)
/// ).getReceipt(client);
/// ```
/// ```go
/// response, err := hedera.NewContractExecuteTransaction().
/// SetContractID(contractID).
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// SetGas(10000).
/// SetFunction("setMessage", NewContractFunctionParameters().AddString("new message")).
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
/// The `ContractId` if the instance to execute.
/// --
/// The maximum amount of gas to use for the execution.
/// --
/// Number of tinybars sent.
/// --
/// Which function to execute, and the parameters to pass to the function. Use
/// [`setFunction(name)`](#setfunction-name-string-contractcallquery) and
/// [`setFunction(name, params)`](#setfunction-name-string-params-contractfunctionparameters-contractcallquery)
/// to set this field.
/// --
/// </summary>
public interface IContractExecuteTransaction
{
}