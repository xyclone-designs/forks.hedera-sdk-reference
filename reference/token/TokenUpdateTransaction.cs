/// <summary>
/// &gt; class `TokenUpdateTransaction` extends [`Transaction`](reference/core/Transaction.md)
/// Updates an already created Token.
/// If no value is given for a field, that field is left unchanged. For an immutable tokens (that is, a token created
/// without an adminKey), only the expiry may be updated. Setting any other field in that case will cause the transaction
/// status to resolve to
/// [`Status.TOKEN_IS_IMMUTABlE`](reference/Status.md#TOKEN_IS_IMMUTABlE).
/// &lt;!-- tabs:start --&gt;
/// ```java
/// newTokenId = new TokenUpdateTransaction()
/// .setTokenId(new TokenId(4))
/// .setName("ffff")
/// .setSymbol("F")
/// .setTreasury(OPERATOR_ID)
/// .setAdminKey(OPERATOR_KEY.publicKey)
/// .setFreezeKey(OPERATOR_KEY.publicKey)
/// .setWipeKey(OPERATOR_KEY.publicKey)
/// .setKycKey(OPERATOR_KEY.publicKey)
/// .setSupplyKey(OPERATOR_KEY.publicKey)
/// .execute(client)
/// .getReceipt(client)
/// .tokenId;
/// ```
/// ```js
/// await (
/// await new TokenUpdateTransaction()
/// .setNodeAccountIds([response.nodeId])
/// .setTokenId(token)
/// .setTokenName("aaaa")
/// .setTokenSymbol("A")
/// .execute(client)
/// ).getReceipt(client);
/// ```
/// `Duration` is `number` and is the number of seconds
/// ```go
/// response, err = hedera.NewTokenUpdateTransaction().
/// SetTokenID(tokenID).
/// SetTokenSymbol("A").
/// SetNodeAccountIDs([]AccountID{response.NodeID}).
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
/// The Token to be updated
/// --
/// The new Name of the Token. Must be a string of ASCII characters.
/// --
/// The new Symbol of the Token. Must be UTF-8 capitalized alphabetical string identifying the token.
/// --
/// The new Treasury account of the Token. If the provided treasury account is not existing or deleted, the response will be
/// [`Status.INVALID_TREASURY_ACCOUNT_FOR_TOKEN`](reference/Status.md#INVALID_TREASURY_ACCOUNT_FOR_TOKEN).
/// If successful, the Token balance held in the previous Treasury Account is
/// transferred to the new one.
/// --
/// The new Admin key of the Token. If Token is immutable, transaction will resolve to
/// [`Status.TOKEN_IS_IMMUTABlE`](reference/Status.md#TOKEN_IS_IMMUTABlE).
/// --
/// The new KYC key of the Token. If Token does not have currently a KYC key, transaction will resolve to
/// [`Status.TOKEN_HAS_NO_KYC_KEY`](reference/Status.md#TOKEN_HAS_NO_KYC_KEY).
/// --
/// The new Freeze key of the Token. If the Token does not have currently a Freeze key, transaction will resolve to
/// [`Status.TOKEN_HAS_NO_FREEZE_KEY`](reference/Status.md#TOKEN_HAS_NO_FREEZE_KEY).
/// --
/// The new Wipe key of the Token. If the Token does not have currently a Wipe key, transaction will resolve to
/// [`Status.TOKEN_HAS_NO_WIPE_KEY`](reference/Status.md#TOKEN_HAS_NO_WIPE_KEY).
/// --
/// The new Supply key of the Token. If the Token does not have currently a Supply key, transaction will resolve to
/// [`Status.TOKEN_HAS_NO_SUPPLY_KEY`](reference/Status.md#TOKEN_HAS_NO_SUPPLY_KEY).
/// --
/// The new expiry time of the token. Expiry can be updated even if admin key is not set. If the provided expiry is earlier
/// than the current token expiry, transaction wil resolve to
/// [`Status.INVALID_EXPIRATION_TIME`](reference/Status.md#INVALID_EXPIRATION_TIME).
/// --
/// The new account which will be automatically charged to renew the token's expiration, at autoRenewPeriod interval.
/// --
/// The new interval at which the auto-renew account will be charged to extend the token's expiry.
/// --
/// The Key which can pause and unpause the Token. If the Token does not currently
/// have a pause key, transaction will resolve to TOKEN\_HAS\_NO\_PAUSE\_KEY
/// --
/// </summary>
public interface ITokenUpdateTransaction
{
}