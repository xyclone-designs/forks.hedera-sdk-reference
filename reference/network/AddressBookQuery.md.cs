namespace Hedera.Hashgraph.Reference.Network
{
    /// <summary>
    /// </summary>
    public interface IAddressBookQuery
    {
        /// <summary>
        ///
        /// Execute this query against a mirror node to get the address book.
        ///
        ///
        /// </summary>
        AddressBook Execute(IClient client)

        /// <summary>
        ///
        /// The file ID of the address book to query
        ///
        /// **NOTE**: You can use `FileId.ADDRESS_BOOK`
        ///
        ///
        /// </summary>
        IFileId FileId { get; }

        /// <summary>
        ///
        /// Limit the amount of nodes to return. If unset will return entire address book.
        ///
        /// </summary>
        Uint32? Limit { get; }

    }
}
