/// <summary>
/// &gt; class `NetworkVersionInfoQuery`
/// &gt; extends [`Query`](reference/core/Query.md) &lt;
/// &gt; [`NetworkVersionInfo`](reference/network/NetworkVersionInfo.md) &gt;
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new NetworkVersionInfoQuery().execute(client);
/// ```
/// ```javascript
/// await new NetworkVersionInfoQuery()
/// .setAccountId(account)
/// .setNodeAccountIds([response.nodeId])
/// .setHash(_hash)
/// .execute(client);
/// ```
/// ```go
/// _, err := NewNetworkVersionQuery().
/// SetMaxQueryPayment(NewHbar(1)).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// </summary>
public interface INetworkVersionInfoQuery
{
}