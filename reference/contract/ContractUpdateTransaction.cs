/// <summary>
/// &gt; class `ContractUpdateTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new ContractUpdateTransaction()
/// .setContractId(contractId)
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .setContractMemo("[e2e::ContractUpdateTransaction]")
/// .execute(client)
/// .getReceipt(client);
/// ```
/// ```js
/// await (
/// await new ContractUpdateTransaction()
/// .setContractId(contract)
/// .setNodeAccountIds([response.nodeId])
/// .setContractMemo("[e2e::ContractUpdateTransaction]")
/// .setMaxTransactionFee(new Hbar(5))
/// .execute(client)
/// ).getReceipt(client);
/// ```
/// ```go
/// response, err := hedera.NewContractUpdateTransaction().
/// SetContractID(contractID).
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// SetContractMemo("[e2e::ContractUpdateTransaction]").
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
/// The id of the contract to be updated.
/// --
/// The new key to control updates/deletion of the contract.
/// --
/// The new expiry of the contract, no earlier than the current expiry.
/// --
/// Deprecated: with no replacement
/// ***Not yet implemented***
/// &lt;br&gt;
/// The new id of the account to which the contract is proxy staked.
/// --
/// ***Not yet implemented***
/// &lt;br&gt;
/// The new interval at which the contract will pay to extend its expiry.
/// --
/// The new id of the file asserted to contain the bytecode of the Solidity transaction that created this contract.
/// --
/// The new contract memo, assumed to be Unicode encoded with UTF-8 (at most 100 bytes).
/// --
/// ID of the account to which this contract is staking.
/// --
/// ID of the node this contract is staked to.
/// --
/// If true, the contract declines receiving a staking reward. The default value is false.
/// --
/// </summary>
public interface IContractUpdateTransaction
{
}