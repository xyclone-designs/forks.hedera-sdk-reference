/// <summary>
/// &gt; class `TokenDeleteTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// Marks a token as deleted, though it will remain in the ledger.
/// The operation must be signed by the specified Admin Key of the Token. If admin key is not set, Transaction will result
/// in
/// [`Status.TOKEN_IS_IMMUTABlE`](reference/Status.md#TOKEN_IS_IMMUTABlE).
/// Once deleted update, mint, burn, wipe, freeze, unfreeze, grant kyc, revoke kyc and token transfer transactions will resolve to
/// [`Status.TOKEN_WAS_DELETED`](reference/Status.md#TOKEN_WAS_DELETED).
/// &lt;!-- tabs:start --&gt;
/// ```java
/// newTokenId = new TokenDeleteTransaction()
/// .setTokenId(new TokenId(4))
/// .execute(client)
/// .getReceipt(client);
/// ```
/// ```js
/// await (
/// await new TokenDeleteTransaction()
/// .setTokenId(tokenId)
/// .execute(client)
/// ).getReceipt(client);
/// ```
/// ```go
/// response, err = hedera.NewTokenDeleteTransaction().
/// SetNodeAccountIDs([]AccountID{response.NodeID}).
/// SetTokenID(tokenID).
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
/// The Token to be Deleted
/// --
/// </summary>
public interface ITokenDeleteTransaction
{
}