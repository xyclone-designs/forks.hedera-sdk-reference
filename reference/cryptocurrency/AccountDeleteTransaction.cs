/// <summary>
/// &gt; class `AccountDeletedTransaction` extends [`Transaction`](../core/Transaction.md)
/// Mark an account as deleted, moving all its current hbars to another account. It will remain in
/// the ledger, marked as deleted, until it expires. Transfers into it a deleted account fail. But a
/// deleted account can still have its expiration extended in the normal way.
/// &gt; [!WARNING]
/// &gt; When you delete an account, you need to sign it with the key set at account creation.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// new AccountDeleteTransaction()
/// .setAccountId(accountId)
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .setTransferAccountId(operatorId)
/// .freezeWith(client)
/// .sign(key)
/// .execute(client)
/// .getReceipt(client);
/// ```
/// ```js
/// await (
/// await (
/// await new AccountDeleteTransaction()
/// .setAccountId(account)
/// .setNodeAccountIds([response.nodeId])
/// .setTransferAccountId(operatorId)
/// .setTransactionId(TransactionId.generate(account))
/// .freezeWith(client)
/// .sign(key)
/// ).execute(client)
/// ).getReceipt(client);
/// ```
/// `Duration` is `number` and is the number of seconds
/// ```go
/// newKey := hedera.GeneratePrivateKey()
/// transaction, err := hedera.NewAccountDeleteTransaction().
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// SetAccountID(accountID).
/// SetTransferAccountID(client.GetOperatorAccountID()).
/// SetTransactionID(TransactionIDGenerate(accountID)).
/// FreezeWith(client)
/// if err != nil {
/// println(err.Error())
/// }
/// resp, err = transaction.
/// Sign(newKey).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// _, err = resp.GetReceipt(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// The AccountId which should be deleted
/// --
/// The `AccountId` which will receive all remaining hbars
/// </summary>
public interface IAccountDeleteTransaction
{
}