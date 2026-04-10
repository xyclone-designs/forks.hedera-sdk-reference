using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// The config file specification for [`Client`](Client.md) construction
    /// </summary>
    public interface IClientConfig
    {
        /// <summary>
        /// The custom network map
        ///
        /// The key is the address and the value is the serialized form of
        /// [`AccountId`](../cryptocurrency/AccountId.md)
        /// </summary>
        IDictionary <string, string> NetworkMap { get; }

        /// <summary>
        /// The name of the network
        ///
        /// Valid values are "previewnet", "testnet", or "mainnet"
        /// </summary>
        string Network { get; }

        /// <summary>
        /// The custom mirror network list
        ///
        /// Each value in the list is the address to a mirror node
        /// </summary>
        IList<string> MirrorNetworkAddresses { get; }

        /// <summary>
        /// The name of the mirror network
        ///
        /// Valid values are "previewnet", "testnet", or "mainnet"
        /// </summary>
        string MirrorNetwork { get; }

        /// <summary>
        /// The operator for the given client
        /// </summary>
        IOperatorConfig Operator { get; }

        /// <summary>
        /// Set the name of the given network.
        ///
        /// Useful when `network` is a custom network map
        /// </summary>
        string NetworkName { get; }

    }
}
