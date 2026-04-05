/// <summary>
/// &gt; class `TokenInfoQuery` extends [`Query`](reference/core/Query.md) &lt; [`TokenInfo`](reference/token/TokenInfo.md) &gt;
/// &lt;details&gt;
/// &lt;summary&gt;&lt;b&gt;Declaration&lt;/b&gt;&lt;/summary&gt;
/// ```typescript
/// class TokenInfoQuery extends Query&lt;TokenInfo&gt; {
/// constructor();
/// /* property */ TokenId: TokenId;
/// }
/// ```
/// &lt;/details&gt;
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var info = new TokenInfoQuery()
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .setTokenId(tokenId)
/// .execute(client);
/// ```
/// ```javascript
/// const info = await new TokenInfoQuery()
/// .setNodeAccountIds([response.nodeId])
/// .setTokenId(tokenId)
/// .execute(client);
/// ```
/// ```go
/// info, err := NewTokenInfoQuery().
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// SetTokenID(tokenID).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// --
/// </summary>
public interface ITokenInfoQuery
{
}