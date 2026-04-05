/// <summary>
/// &gt; class `AddressBookQuery`
/// &lt;!-- tabs:start --&gt;
/// ```java
/// var addressBook = new AddressBookQuery()
/// .setFileId(fileId)
/// .execute(client);
/// ```
/// ```javascript
/// const addressBook = await new AddressBookQuery()
/// .setFileId(account)
/// .execute(client);
/// ```
/// ```go
/// addressBook, err := NewAddressBookQuery().
/// SetFileID(fileID).
/// Execute(client)
/// if err != nil {
/// println(err.Error())
/// }
/// ```
/// &lt;!-- tabs:end --&gt;
/// --
/// Execute this query against a mirror node to get the address book.
/// --
/// The file ID of the address book to query
/// **NOTE**: You can use `FileId.ADDRESS_BOOK`
/// --
/// Limit the amount of nodes to return. If unset will return entire address book.
/// --
/// </summary>
public interface IAddressBookQuery
{
}