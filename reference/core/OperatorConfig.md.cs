using Hedera.Hashgraph.Reference.Cryptography;

namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// The operator config file specification for [`Client`](Client.md) construction
    /// </summary>
    public interface IOperatorConfig
    {
        /// <summary>
        /// The account ID of the operator
        /// </summary>
        string AccountId { get; }

        /// <summary>
        /// The private key of the operator
        /// </summary>
        IPrivateKey PrivateKey { get; }
    }
}
