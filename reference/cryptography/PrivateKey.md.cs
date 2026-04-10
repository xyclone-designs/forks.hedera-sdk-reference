using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;

namespace Hedera.Hashgraph.Reference.Cryptography
{
    /// <summary>
    /// A private key on the Hedera™ network.
    ///
    /// > :bulb: **Tip:** Use "" for an empty passphrase
    /// </summary>
    public class PrivateKey : Key
    {
        /// <summary>
        /// Parses a DER encoded Ed25519 or ECDSA private key
        ///
        /// **Note**: The use of raw bytes for an Ed25519 private key is deprecated; use `fromBytesEd25519()` instead.
        /// </summary>
        public static PrivateKey FromBytes(byte[] data);
        /// <summary>
        /// Parses a DER encoded Ed25519 or ECDSA private key
        ///
        /// **Note**: Does **not** support raw bytes; the data provided must be DER encoded.
        /// </summary>
        public static PrivateKey FromBytesDer(byte[] data);
        /// <summary>
        /// Parses an ECDSA private key from either DER encoded or raw bytes.
        /// </summary>
        public static PrivateKey FromBytesEcdsa(byte[] data);
        /// <summary>
        /// Parses an Ed25519 private key from either DER encoded or raw bytes.
        /// </summary>
        public static PrivateKey FromBytesEd25519(byte[] data);
        /// <summary>
        /// Recovers an ed25519 private key from a 24, 22, or 12 word mnemonic. 24 and
        /// 12 word mnemonics use a BIP-32 word list and SLIP-10 derivation. 22 word
        /// mnemonics use a legacy word list from the original Hedera mobile wallets.
        /// </summary>
        public static PrivateKey FromMnemonic(string mnemonic, string passphrase);
        /// <summary>
        /// Parse a private key from a PEM encoded string.
        /// </summary>
        public static PrivateKey FromPem(string pem);
        /// <summary>
        /// Extract the ECDSA private key from a seed.
        /// </summary>
        public static PrivateKey FromSeedECDSAsecp256k1(byte[] seed);
        /// <summary>
        /// Extract the ED25519 private key from a seed.
        /// </summary>
        public static PrivateKey FromSeedED25519(byte[] seed);
        /// <summary>
        /// Parses a HEX and DER encoded Ed25519 or ECDSA private key
        ///
        /// **Note**: The use of raw bytes for an Ed25519 private key is deprecated; use `fromStringEd25519()` instead.
        /// </summary>
        public static PrivateKey FromString(string text);
        /// <summary>
        /// Parses a HEX and DER encoded Ed25519 or ECDSA private key
        ///
        /// **Note**: Does **not** support raw bytes; the data provided must be DER encoded.
        /// </summary>
        public static PrivateKey FromStringDer(string text);
        /// <summary>
        /// Parses an ECDSA private key from either HEX and DER encoded bytes or just HEX encoded raw bytes.
        /// </summary>
        public static PrivateKey FromStringEcdsa(string text);
        /// <summary>
        /// Parses an Ed25519 private key from either HEX and DER encoded bytes or just HEX encoded raw bytes.
        /// </summary>
        public static PrivateKey FromStringEd25519(string text);
        /// <summary>
        /// Recovers an PrivateKey from an encrypted keystore encoded as a byte slice.
        /// </summary>
        public static PrivateKey FromKeystore(byte[] data, string passphrase);
        /// <summary>
        /// Generates a new Ed25519 private key.
        ///
        /// Deprecated: Use `generateEd5519()` or `generateEcdsa()` instead.
        /// </summary>
        public static PrivateKey Generate();
        /// <summary>
        /// Generates a new ECDSA private key.
        /// </summary>
        public static PrivateKey GenerateEcdsa();
        /// <summary>
        /// Generates a new Ed25519 private key.
        ///
        /// ###### Errors
        ///
        /// - [`BadMnemonic`](../error/BadMnemonic.md) — when the mnemonic contains
        /// words not found in the word list; there is a checksum mismatch; or, an
        /// unexpected number of words.
        ///
        /// </summary>
        public static PrivateKey GenerateEd25519();

        /// <summary>
        /// Given a wallet/account index, derive a child key compatible with the iOS and Android wallets.
        /// </summary>
        IPrivateKey Derive(long index);

        /// <summary>
        /// Check if this private key supports derivation.
        /// </summary>
        bool IsDerivable();
        /// <summary>
        /// Check if this private key is an ECDSA key.
        /// </summary>
        bool IsECDSA();
        /// <summary>
        /// Check if this private key is an ED25519 key.
        /// </summary>
        bool IsED25519();

        /// <summary>
        /// Derive a legacy child key based on the index
        /// </summary>
        IPrivateKey LegacyDerive(long index);

        /// <summary>
        /// Sign a message with this private key.
        /// </summary>
        byte[] Sign(byte[] message);
        /// <summary>
        /// Sign a transaction with this private key.
        /// </summary>
        byte[] SignTransaction(ITransaction transaction);

        /// <summary>
        /// Convert this private key into an account ID with a given shard and realm.
        ///
        /// Note: The account ID created will use the `publicKey` property of this `PrivateKey`,
        /// not the `PrivateKey` bytes.
        /// </summary>
        AccountId ToAccountId(long shard, long realm);

        /// <summary>
        /// Serialize the private key into bytes.
        ///
        /// **Note**: For `Ed25519` the result of this method call is identical to `toBytesRaw()` while for `ECDSA`
        /// this method is identical to `toBytesDer()`.
        ///
        /// We strongly recommend using `toBytesRaw()` or `toBytesDer()` instead.
        /// </summary>
        byte[] ToBytes();
        /// <summary>
        /// Serialize the private key into bytes using PKCS and DER encoding.
        /// </summary>
        byte[] ToBytesDer();
        /// <summary>
        /// Return just the raw bytes for the given key.
        /// </summary>
        byte[] ToBytesRaw();
        /// <summary>
        /// Converts the private key into a keystore which can be saved on disk
        /// </summary>
        byte[] ToKeystore(string passphrase);
        /// <summary>
        /// See: [`toStringDer()`](#tostringder----string);
        /// </summary>
        string ToString();
        /// <summary>
        /// Encodes [`toBytesDer()`](#tobytesder----bytes) into HEX.
        ///
        /// **Note**: This results in a string which has the key data of the private key prefixed with a header.
        /// </summary>
        string ToStringDer();
        /// <summary>
        /// Encodes [`toBytesRaw()`](#tobytesraw----bytes) into HEX.
        ///
        /// </summary>
        string ToStringRaw();

        /// <summary>
        /// Derive a public key from this private key.
        /// </summary>
        IPublicKey PublicKey { get; }
    }
}
