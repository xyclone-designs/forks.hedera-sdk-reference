using System;

namespace Hedera.Hashgraph.Reference
{
    public class LedgerId(byte[] idBytes)
    {
        private readonly byte[] IdBytes = idBytes;

        /// <summary>
        /// The ledger ID for mainnet
        /// </summary>
        public static readonly LedgerId MAINNET = new([0]);
        /// <summary>
        /// The ledger ID for testnet
        /// </summary>
        public static readonly LedgerId TESTNET = new([1]);
        /// <summary>
        /// The ledger ID for previewnet
        /// </summary>
        public static readonly LedgerId PREVIEWNET = new([2]);

        /// <summary>
        /// Construct the ledger ID from bytes directly.
        ///
        /// **NOTE**: Using the UTF-8 byte representation of `"mainnet"`, `"testnet"`,
        /// or `"previewnet"` is **NOT** supported.
        /// </summary>
        public static LedgerId FromBytes(byte[] bytes)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Construct a ledger ID from a string.
        ///
        /// **NOTE**: The string can be either hex encoded bytes or `"mainnet"`, `"testnet"`,
        /// or `"previewnet"`.
        /// </summary>
        public static LedgerId FromString(string ledgerId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Convert this `NetworkName` into a `LedgerId`
        ///
        /// **NOTE**: If `NetworkName` is `OTHER` this will err.
        /// </summary>
        //public static LedgerId FromNetworkName(NetworkName networkName)
        //{
        //    return networkName switch
        //    {
        //        NetworkName.MainNet => MAINNET,
        //        NetworkName.TestNet => TESTNET,
        //        NetworkName.PreviewNet => PREVIEWNET,

        //        _ => throw new ArgumentException("networkName must be MAINNET, TESTNET, or PREVIEWNET"),
        //    };
        //}

        /// <summary>
        /// Return if this ledger ID represents a mainnet ledger ID.
        /// </summary>
        public virtual bool IsMainnet() => Equals(MAINNET);
        /// <summary>
        /// Return if this ledger ID represents a testnet ledger ID.
        /// </summary>
        public virtual bool IsTestnet() => Equals(TESTNET);
        /// <summary>
        /// Return if this ledger ID represents a previewnet ledger ID.
        /// </summary>
        public virtual bool IsPreviewnet() => Equals(PREVIEWNET);

        /// <summary>
        /// Stringify the ledger ID
        ///
        /// **NOTE**: If the ledger ID is a known value such as `[0]`, `[1]`, `[2]` this method
        /// will instead return `"mainnet"`, `"testnet"`, or `"previewnet"`, otherwise it will
        /// hex encode the bytes.
        /// </summary>
        public override string ToString()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return the ledger ID bytes
        /// </summary>
        public virtual byte[] ToBytes()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Convert this ledger ID into a `NetworkName`.
        ///
        /// **NOTE**: If the ledger ID is not a recognzied ledger ID the resulting
        /// `NetworkName` will be `OTHER`.
        /// </summary>
        //public virtual NetworkName ToNetworkName()
        //{
        //    return true switch
        //    {
        //        true when IsMainnet => NetworkName.MainNet,
        //        true when IsTestnet => NetworkName.TestNet,
        //        true when IsPreviewnet => NetworkName.PreviewNet,

        //        _ => NetworkName.Other
        //    };
        //}
    }
}
