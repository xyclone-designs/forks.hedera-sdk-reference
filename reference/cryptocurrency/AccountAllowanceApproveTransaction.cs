/// <summary>
/// &gt; class `AccountAllowanceApproveTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// Creates one or more hbar/token approved allowances &lt;b&gt;relative to the payer account of this
/// transaction&lt;/b&gt;. Each allowance grants a spender the right to transfer a pre-determined
/// amount of the payer's hbar/token to any other account of the spender's choice.
/// (So if account &lt;tt&gt;0.0.X&lt;/tt&gt; pays for this transaction, then at consensus each spender
/// account will have new allowances to spend hbar or tokens from &lt;tt&gt;0.0.X&lt;/tt&gt;).
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new AccountAllowanceApproveTransaction()
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .addHbarApprove(accountId, Hbar.fromTinybars(10))
/// .addTokenApprove(tokenId, accountId, 10)
/// .addTokenNftApprove(tokenId, accountId, null)
/// .execute(client)
/// .getReceipt(client);
/// ```
/// ```js
/// await (
/// await new AccountAllowanceApproveTransaction()
/// .setNodeAccountIds([response.nodeId])
/// .addHbarApprove(accountId, Hbar.fromTinybars(10))
/// .addTokenApprove(tokenId, accountId, 10)
/// .addTokenApprove(tokenId, accountId, null)
/// .execute(client)
/// ).getReceipt(client);
/// ```
/// `Duration` is `number` and is the number of seconds
/// ```go
/// newKey := hedera.GeneratePrivateKey()
/// resp, err := hedera.NewAccountAllowanceApproveTransaction().
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// AddHbarApprove(accountID, HbarFromTinybars(10)).
/// AddTokenApprove(tokenID, accountID, 10).
/// AddTokenApprove(tokenID, accountID, null).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// _, err = resp.GetReceipt(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// Add a Hbar allowance
/// Transaction fee payer is implicitly the allowance owner.
/// Deprecated: use `ApproveHbarAllowance` instead.
/// --
/// Approve an Hbar allowance
/// --
/// Get the current list of hbar approves for this transaction.
/// --
/// Add a fungible token approve
/// Transaction fee payer is implicitly the allowance owner.
/// Deprecated: use `approveTokenAllowance` instead.
/// --
/// Approve a fungible token allowance.
/// --
/// Get the current list of hbar approves for this transaction.
/// --
/// Add a non-fungible token approve
/// Transaction fee payer is implicitly the allowance owner.
/// Deprecated: use `approveTokenNftAllowance` instead.
/// --
/// Approve a non-fungible token allowance
/// --
/// Add all non-fungible tokens to approve
/// Transaction fee payer is implicitly the allowance owner.
/// Deprecated: use `approveTokenNftAllowanceAllSerials` instead.
/// --
/// Approve an allowance of all serial numbers of a non-fungible token.
/// --
/// Get the list of all non-fungible token approves for this transaction
/// --
/// </summary>
public interface IAccountAllowanceApproveTransaction
{
}