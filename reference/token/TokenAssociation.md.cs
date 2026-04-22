using Hedera.Hashgraph.Reference.Cryptocurrency;

namespace Hedera.Hashgraph.Reference.Token
{
    /// <summary>
    /// An assocation of a [`TokenId`](reference/token/TokenId.md) and
    /// [`AccountId`](reference/cryptocurrency/AccountId.md)
    /// </summary>
    public interface ITokenAssociation 
    {
        /// <summary>
        /// Serialize this token assocaiton into its protobuf representation.
        /// </summary>
        byte[] ToBytes();

        /// <summary>
        /// Stringify the token assocation
        /// </summary>
        string ToString();

        /// <summary>
        /// The account ID
        /// </summary>
        IAccountId AccountId { get; }

        /// <summary>
        /// The token ID
        /// </summary>
        ITokenId TokenId { get; }
    }
}
