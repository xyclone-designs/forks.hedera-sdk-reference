namespace Hedera.Hashgraph.Reference
{
    public interface ILedgerId
    {
        /// <summary>
        /// Construct the ledger ID from bytes directly.
        ///
        /// **NOTE**: Using the UTF-8 byte representation of `"mainnet"`, `"testnet"`,
        /// or `"previewnet"` is **NOT** supported.
        /// </summary>
        abstract static ILedgerId FromBytes(byte[] bytes);
        /// <summary>
        /// Construct a ledger ID from a string.
        ///
        /// **NOTE**: The string can be either hex encoded bytes or `"mainnet"`, `"testnet"`,
        /// or `"previewnet"`.
        /// </summary>
        abstract static ILedgerId FromString(string ledgerId);
        /// <summary>
        /// Convert this `NetworkName` into a `LedgerId`
        ///
        /// **NOTE**: If `NetworkName` is `OTHER` this will err.
        /// </summary>
        abstract static ILedgerId FromNetworkName(INetworkName networkName);

        /// <summary>
        /// Return if this ledger ID represents a mainnet ledger ID.
        /// </summary>
        bool IsMainnet();
        /// <summary>
        /// Return if this ledger ID represents a testnet ledger ID.
        /// </summary>
        bool IsTestnet();
        /// <summary>
        /// Return if this ledger ID represents a previewnet ledger ID.
        /// </summary>
        bool IsPreviewnet();

        /// <summary>
        /// Return the ledger ID bytes
        /// </summary>
        byte[] ToBytes();
        /// <summary>
        /// Stringify the ledger ID
        ///
        /// **NOTE**: If the ledger ID is a known value such as `[0]`, `[1]`, `[2]` this method
        /// will instead return `"mainnet"`, `"testnet"`, or `"previewnet"`, otherwise it will
        /// hex encode the bytes.
        /// </summary>
        string ToString();
        /// <summary>
        /// Convert this ledger ID into a `NetworkName`.
        ///
        /// **NOTE**: If the ledger ID is not a recognzied ledger ID the resulting
        /// `NetworkName` will be `OTHER`.
        /// </summary>
        INetworkName ToNetworkName();

        /// <summary>
        /// The ledger ID for mainnet
        /// </summary>
        abstract static ILedgerId MAINNET { get; }
        /// <summary>
        /// The ledger ID for testnet
        /// </summary>
        abstract static ILedgerId TESTNET { get; }
        /// <summary>
        /// The ledger ID for previewnet
        /// </summary>
        abstract static ILedgerId PREVIEWNET { get; }
    }
}
