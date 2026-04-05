/// <summary>
/// &gt; class `TokenUnpauseTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// Unpauses the Token. Must be signed with the Token's pause key.  If the provided
/// token is not found, the transaction will resolve to INVALID\_TOKEN\_ID.  If the
/// provided token has been deleted, the transaction will resolve to
/// TOKEN\_WAS\_DELETED.  If no Pause Key is defined, the transaction will resolve to
/// TOKEN\_HAS\_NO\_PAUSE\_KEY.  Once executed the Token is marked as Unpaused and can
/// be used in Transactions.  The operation is idempotent - becomes a no-op if the
/// Token is already unpaused.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var receipt = new TokenUnpauseTransaction()
/// .setTokenId(tokenId)
/// .execute(client) // TransactionResponse
/// .getReceipt(client); // TransactionReceipt
/// ```
/// ```javascript
/// const transaction = new TokenUnpauseTransaction()
/// .setTokenId(tokenId);
/// const response = await transaction.execute(client) // TransactionResponse;
/// const receipt = await response.getReceipt(client) // TransactionReceipt;
/// ```
/// `Duration` is `number` and is the number of seconds
/// ```go
/// response, err := hedera.NewTokenUnpauseTransaction().
/// SetTokenID(tokenID).
/// Execute(client) // TransactionResponse
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
/// The token to be unpaused.
/// --
/// </summary>
public interface ITokenUnpauseTransaction
{
}