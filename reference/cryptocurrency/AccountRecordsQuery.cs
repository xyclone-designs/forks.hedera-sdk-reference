/// <summary>
/// &gt; class `AccountRecordsQuery`
/// &gt; extends [`Query`](../core/Query.md) &lt;
/// &gt; [`TransactionRecord[]`](../core/TransactionRecord.md) &gt;
/// Request records of all transactions for which the given account was the
/// effective payer in the last 3 minutes of consensus time and
/// &lt;tt&gt;ledger.keepRecordsInState=true&lt;/tt&gt; was true during
/// &lt;tt&gt;handleTransaction&lt;/tt&gt;.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var records = new AccountRecordsQuery()
/// .setNodeAccountIds(Collections.singletonList(response.nodeId))
/// .setAccountId(accountId)
/// .execute(client);
/// ```
/// ```javascript
/// const records = await new AccountRecordsQuery()
/// .setNodeAccountIds([response.nodeId])
/// .setAccountId(operatorId)
/// .execute(client);
/// ```
/// ```go
/// recordsQuery, err := NewAccountRecordsQuery().
/// SetNodeAccountIDs([]AccountID{resp.NodeID}).
/// SetAccountID(client.GetOperatorAccountID()).
/// SetMaxQueryPayment(NewHbar(1)).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// The account ID for which the records should be retrieved
/// </summary>
public interface IAccountRecordsQuery
{
}