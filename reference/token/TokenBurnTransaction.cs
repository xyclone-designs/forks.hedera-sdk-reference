/// <summary>
/// &gt; class `TokenBurnTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// Burns tokens from the Token's treasury Account. If no Supply Key is defined, the transaction will resolve to
/// [`Status.TOKEN_HAS_NO_SUPPLY_KEY`](reference/Status.md#TOKEN_HAS_NO_SUPPLY_KEY).
/// The operation decreases the Total Supply of the Token. Total supply cannot go below zero.
/// The amount provided must be in the lowest denomination possible. Example:
/// Token A has 2 decimals. In order to burn 100 tokens, one must provide amount of 10000. In order to burn 100.55 tokens,
/// one must provide amount of 10055.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// newTokenID = new TokenBurnTransaction()
/// .setTokenId(new TokenId(4))
/// .setAmount(10)
/// .execute(client)
/// .getReceipt(client);
/// ```
/// ```js
/// response = await new TokenBurnTransaction()
/// .setAmount(10)
/// .setTokenId(tokenId)
/// .execute(client)
/// newTokenID = (await response.getReceipt(client)).tokenId;
/// ```
/// ```go
/// response, err = hedera.NewTokenBurnTransaction().
/// SetNodeAccountIDs([]AccountID{response.NodeID}).
/// SetAmount(10).
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
/// The token for which to burn tokens. If token does not exist, transaction results in
/// [`Status.INVALID_TOKEN_ID`](reference/Status.md#INVALID_TOKEN_ID).
/// --
/// The amount to burn from the Treasury Account. Amount must be a positive non-zero number, not bigger than the token
/// balance of the treasury account (0; balance], represented in the lowest denomination.
/// --
/// </summary>
public interface ITokenBurnTransaction
{
}