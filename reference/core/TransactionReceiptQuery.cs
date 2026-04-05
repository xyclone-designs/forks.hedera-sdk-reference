/// <summary>
/// &gt; class `TransactionReceiptQuery` extends [`Query`](Query.md) &lt; [`TransactionReceipt`](TransactionReceipt.md) &gt;
/// Get the receipt of a transaction, given its transaction ID.
/// &lt;br&gt;
/// Once a transaction reaches consensus, then information about whether it succeeded or failed will be available until the end of the receipt period.
/// &lt;br&gt;
/// This query is free.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var receipt = new TransactionReceiptQuery()
/// .setTransactionId(myTransactionId)
/// .execute(client);
/// ```
/// ```javascript
/// const receipt = await new TransactionReceiptQuery({
/// transactionId: myTransactionId,
/// }).execute(client);
/// ```
/// ```go
/// receipt, err := NewTransactionReceiptQuery().
/// SetTransactionID(response.TransactionID).
/// SetNodeAccountIDs([]AccountID{response.NodeID}).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// Whether receipts of processing duplicate transactions should be returned along with the
/// receipt of processing the first consensus transaction with the given id whose status was
/// neither &lt;tt&gt;INVALID\_NODE\_ACCOUNT&lt;/tt&gt; nor &lt;tt&gt;INVALID\_PAYER\_SIGNATURE&lt;/tt&gt;; &lt;b&gt;or&lt;/b&gt;, if no
/// such receipt exists, the receipt of processing the first transaction to reach consensus with
/// the given transaction id.
/// --
/// Whether the response should include the receipts of any child transactions spawned by the
/// top-level transaction with the given transactionID.
/// --
/// The transaction ID to query the receipt for
/// </summary>
public interface ITransactionReceiptQuery
{
}