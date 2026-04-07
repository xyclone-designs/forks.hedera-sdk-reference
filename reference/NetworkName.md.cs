namespace Hedera.Hashgraph.Reference
{
    /// <summary>
    /// Deprecated: Please use [`LedgerId`](reference/LedgerId.md) instead
    ///
    /// </summary>
    public interface INetworkName
    {
        /// <summary>
        ///
        /// Construct a `NetworkName` from a string: `"mainnet"`, `"testnet"`, or `"previewnet"`.
        ///
        ///
        /// </summary>
        abstract static INetworkName FromString(string networkName)

        /// <summary>
        ///
        /// Stringify the ledger ID to `"mainnet"`, `"testnet"`, or `"previewnet"`
        ///
        /// </summary>
        byte[] ToString()

    }
}
