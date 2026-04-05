/// <summary>
/// &gt; class `AccountStakersQuery`
/// &gt; extends [`Query`](../core/Query.md) &lt;
/// &gt; [`ProxyStaker[]`](../cryptocurrency/ProxyStaker.md) &gt;
/// Get all the accounts that are proxy staking to this account. For each of them, give the amount
/// currently staked. This is not yet implemented, but will be in a future version of the API.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new AccountStakersQuery()
/// .setAccountId(operatorId)
/// .setMaxQueryPayment(new Hbar(1))
/// .execute(client);
/// ```
/// ```javascript
/// await new AccountStakersQuery()
/// .setAccountId(operatorId)
/// .setMaxQueryPayment(new Hbar(1))
/// .execute(client);
/// ```
/// ```go
/// _, err := NewAccountStakersQuery().
/// SetAccountID(client.GetOperatorAccountID()).
/// SetMaxQueryPayment(NewHbar(1)).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// The `AccountId` for which the records should be retrieved
/// --
/// </summary>
public interface IAccountStakersQuery
{
}