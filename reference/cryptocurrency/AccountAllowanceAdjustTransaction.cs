/// <summary>
/// &gt; class `AccountAllowanceAdjustTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// &lt;b&gt;WARNING&lt;/b&gt;: This class has been **deprecated** and is no longer supported by the Hedera protobufs.
/// Modifies or creates the hbar/token allowance for a spender &lt;b&gt;relative to the payer account
/// of this transaction&lt;/b&gt;.
/// (So if account &lt;tt&gt;0.0.X&lt;/tt&gt; pays for this transaction, then at consensus the spender
/// account will have new allowances to spend hbar or tokens from &lt;tt&gt;0.0.X&lt;/tt&gt;).
/// &lt;b&gt;IMPORTANT&lt;/b&gt;: If an allowance for the spender does not currently exist, this transaction
/// behaves like an allowance approval.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new AccountAllowanceAdjustTransaction() .setNodeAccountIds(Collections.singletonList(response.nodeId)) .addHbarAllowance(accountId, Hbar.fromTinybars(10))
/// .addTokenAllowance(tokenId, accountId, 10)
/// .addAllTokenNftAllowance(tokenId, accountId)
/// .execute(client)
/// .getReceipt(client);
/// ```
/// ```js
/// await (
/// await new AccountAllowanceAdjustTransaction()
/// .setNodeAccountIds([response.nodeId])
/// .addHbarAllowance(accountId, Hbar.fromTinybars(10))
/// .addTokenAllowance(tokenId, accountId, 10)
/// .addAllTokenNftAllowance(tokenId, accountId)
/// .execute(client)
/// ).getReceipt(client);
/// ```
/// `Duration` is `number` and is the number of seconds
/// ```go
/// response, err := hedera.NewAccountAllowanceAdjustTransaction().
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// AddHbarAllowance(accountId, Hbar.fromTinybars(10)).
/// AddTokenAllowance(tokenId, accountId, 10).
/// AddAllTokenNftAllowance(tokenId, accountId).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// _, err = response.GetReceipt(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// Add a Hbar allowance
/// Transaction fee payer is implicitly the allowance owner.
/// Deprecated: use `[grant|revoke]HbarAllowance` instead.
/// --
/// Increase an Hbar Allowance.
/// --
/// Decrease an Hbar Allowance.
/// --
/// Get the current list of hbar allowances for this transaction.
/// --
/// Add a fungible token allowance
/// Transaction fee payer is implicitly the allowance owner.
/// Deprecated: use `[grant|revoke]TokenAllowance` instead.
/// --
/// Increase a fungible token allowance.
/// --
/// Decrease a fungible token allowance.
/// --
/// Get the current list of hbar allowances for this transaction.
/// --
/// Add a non-fungible token allowance
/// Transaction fee payer is implicitly the allowance owner.
/// Deprecated: use `[grant|revoke]TokenNftAllowance` instead.
/// --
/// Add serials to a non-fungible token allowance.
/// --
/// Remove serials from a non-fungible token allowance.
/// --
/// Add all non-fungible tokens to allowance
/// Transaction fee payer is implicitly the allowance owner.
/// Deprecated: use `[grant|revoke]TokenNftAllowanceAllSerials` instead.
/// --
/// Add all serials to a non-fungible token allowance.
/// --
/// Remove all serials from a non-fungible token allowance.
/// --
/// Get the list of all non-fungible token allowances for this transaction
/// --
/// </summary>
public interface IAccountAllowanceAdjustTransaction
{
}