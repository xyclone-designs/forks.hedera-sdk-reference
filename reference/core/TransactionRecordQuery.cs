/// <summary>
/// &gt; class `TransactionRecordQuery` extends [`Query`](Query.md) &lt; [`TransactionRecord`](TransactionRecord.md) &gt;
/// Get the record for a transaction.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var record = new TransactionRecordQuery()
/// .setTransactionId(myTransactionId)
/// .execute(client);
/// ```
/// ```javascript
/// const record = await new TransactionRecordQuery({
/// transactionId: myTransactionId,
/// }).execute(client);
/// ```
/// ```go
/// record, err := NewTransactionRecordQuery().
/// SetTransactionID(response.TransactionID).
/// SetNodeAccountIDs([]AccountID{response.NodeID}).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// Whether the response should include the records of any child transactions spawned by the
/// top-level transaction with the given transactionID.
/// --
/// Whether records of processing duplicate transactions should be returned along with the record
/// of processing the first consensus transaction with the given id whose status was neither
/// &lt;tt&gt;INVALID\_NODE\_ACCOUNT&lt;/tt&gt; nor &lt;tt&gt;INVALID\_PAYER\_SIGNATURE&lt;/tt&gt;; &lt;b&gt;or&lt;/b&gt;, if no such
/// record exists, the record of processing the first transaction to reach consensus with the
/// given transaction id..
/// --
/// The transaction ID to query the record for
/// </summary>
public interface ITransactionRecordQuery
{
}