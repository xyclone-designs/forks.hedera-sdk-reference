/// <summary>
/// &gt; class `AccountInfoQuery`
/// &gt; extends [`Query`](../core/Query.md) &lt;
/// &gt; [`AccountInfo`](AccountInfo.md) &gt;
/// Get all the information about an account, including the balance. This does not get the list of
/// account records.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var info = new AccountInfoQuery()
/// .setAccountId(accountId)
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .execute(client);
/// ```
/// ```javascript
/// const info = await new AccountInfoQuery()
/// .setNodeAccountIds([response.nodeId])
/// .setAccountId(account)
/// .execute(client);
/// ```
/// ```go
/// info, err := NewAccountInfoQuery().
/// SetAccountID(accountID).
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// The account ID for which information is requested
/// </summary>
public interface IAccountInfoQuery
{
}