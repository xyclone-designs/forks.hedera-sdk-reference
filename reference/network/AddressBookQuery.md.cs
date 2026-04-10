using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.File;

namespace Hedera.Hashgraph.Reference.Network
{
    public interface IAddressBookQuery
    {
        /// <summary>
        /// Execute this query against a mirror node to get the address book.
        /// </summary>
        IAddressBook Execute(Client client);

        /// <summary>
        /// The file ID of the address book to query
        ///
        /// **NOTE**: You can use `FileId.ADDRESS_BOOK`
        /// </summary>
        FileId FileId { get; }

        /// <summary>
        /// Limit the amount of nodes to return. If unset will return entire address book.
        /// </summary>
        uint? Limit { get; }
    }
}
