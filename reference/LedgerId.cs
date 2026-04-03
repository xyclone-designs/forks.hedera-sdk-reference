namespace Hedera.Hashgraph.Reference
{
    public interface ILedgerId
    {
        // TODO: ##### `fromNetworkName` ( `networkName`: [`NetworkName`]() ): `LedgerId`
        // TODO: ##### `toNetworkName` ( ): [`NetworkName`]()

        // TODO: ##### `MAINNET`: `LedgerId`
        // TODO: ##### `TESTNET`: `LedgerId`
        // TODO: ##### `PREVIEWNET`: `LedgerId`

        public abstract static ILedgerId FromBytes(byte[] bytes);
        public abstract static ILedgerId FromNetworkName(string ledgerId);
        public abstract static ILedgerId FromString(string ledgerId);

        public bool IsMainnet { get; }
        public bool IsTestnet { get; }
        public bool IsPreviewnet { get; }

        public string ToBytes();
        public string ToString();
    }
}
