/// <summary>
/// &gt; class `AccountBalanceQuery`
/// &gt; extends [`Query`](../core/Query.md) &lt; [`Hbar`](../Hbar.md) &gt;
/// Get the balance of a cryptocurrency account. This returns only the balance, so it is a smaller
/// reply than CryptoGetInfo, which returns the balance plus additional information.
/// &gt; [!TIP]
/// &gt; `AccountBalanceQuery` is a completely free query and does not even require
/// &gt; `setOperator` to be called on the client.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var balances = new AccountBalanceQuery()
/// .setAccountId(operatorId)
/// .execute(client);
/// ```
/// ```javascript
/// const balances = await new AccountBalanceQuery()
/// .setAccountId("3") // balance of node 3
/// .execute(client);
/// ```
/// ```go
/// balances, err := hedera.NewAccountBalanceQuery().
/// SetAccountID(client.GetOperatorAccountID()).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// The account ID for which information is requested
/// --
/// The contract ID for which information is requested
/// </summary>
public interface IAccountBalanceQuery
{
}