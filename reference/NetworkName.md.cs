namespace Hedera.Hashgraph.Reference
{
    /// <summary>
    /// Deprecated: Please use [`LedgerId`](reference/LedgerId.md) instead
    /// </summary>
    public interface INetworkName
    {
        /// <summary>
        /// Construct a `NetworkName` from a string: `"mainnet"`, `"testnet"`, or `"previewnet"`.
        /// </summary>
        abstract static INetworkName FromString(string networkName);

        /// <summary>
        /// Stringify the ledger ID to `"mainnet"`, `"testnet"`, or `"previewnet"`
        /// </summary>
        byte[] ToString();

        /// <summary>
        /// The ledger ID for mainnet
        /// </summary>
        abstract static INetworkName MAINNET { get; }
        /// <summary>
        /// The ledger ID for testnet
        /// </summary>
        abstract static INetworkName TESTNET { get; }
        /// <summary>
        /// The ledger ID for previewnet
        /// </summary>
        abstract static INetworkName PREVIEWNET { get; }
    }
}
