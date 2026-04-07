namespace Hedera.Hashgraph.Reference.Cryptography
{
    /// <summary>
    /// A public key on the Hedera™ network.
    ///
    /// </summary>
    public interface IPublicKey
    {
        /// <summary>
        ///
        /// Parses a DER encoded Ed25519 or ECDSA public key
        ///
        /// **Note**: The use of raw bytes for an Ed25519 public key is deprecated; use `fromBytesEd25519()` instead.
        ///
        ///
        /// </summary>
        abstract static IPublicKey FromBytes(byte[] data)

        /// <summary>
        ///
        /// Parses a DER encoded Ed25519 or ECDSA public key
        ///
        /// **Note**: Does **not** support raw bytes; the data provided must be DER encoded.
        ///
        ///
        /// </summary>
        abstract static IPublicKey FromBytesDer(byte[] data)

        /// <summary>
        ///
        /// Parses an ECDSA public key from either DER encoded or raw bytes.
        ///
        ///
        /// </summary>
        abstract static IPublicKey FromBytesEcdsa(byte[] data)

        /// <summary>
        ///
        /// Parses an Ed25519 public key from either DER encoded or raw bytes.
        ///
        ///
        /// </summary>
        abstract static IPublicKey FromBytesEd25519(byte[] data)

        /// <summary>
        ///
        /// Parses a HEX and DER encoded Ed25519 or ECDSA public key
        ///
        /// **Note**: The use of raw bytes for an Ed25519 public key is deprecated; use `fromStringEd25519()` instead.
        ///
        ///
        /// </summary>
        abstract static IPublicKey FromString(string text)

        /// <summary>
        ///
        /// Parses a HEX and DER encoded Ed25519 or ECDSA public key
        ///
        /// **Note**: Does **not** support raw bytes; the data provided must be DER encoded.
        ///
        ///
        /// </summary>
        abstract static IPublicKey FromStringDer(string text)

        /// <summary>
        ///
        /// Parses an ECDSA public key from either HEX and DER encoded bytes or just HEX encoded raw bytes.
        ///
        ///
        /// </summary>
        abstract static IPublicKey FromStringEcdsa(string text)

        /// <summary>
        ///
        /// Parses an Ed25519 public key from either HEX and DER encoded bytes or just HEX encoded raw bytes.
        ///
        /// </summary>
        abstract static IPublicKey FromStringEd25519(string text)

        /// <summary>
        ///
        /// Check if this public key is an ECDSA key.
        ///
        ///
        /// </summary>
        bool IsECDSA()

        /// <summary>
        ///
        /// Check if this public key is an ED25519 key.
        ///
        ///
        /// </summary>
        bool IsED25519()

        /// <summary>
        ///
        /// Convert this public key into an account ID with a given shard and realm.
        ///
        ///
        /// </summary>
        IAccountId ToAccountId(long shard, long realm)

        /// <summary>
        ///
        /// Serialize the private key into bytes.
        ///
        /// **Note**: For `Ed25519` the result of this method call is identical to `toBytesRaw()` while for `ECDSA`
        /// this method is identical to `toBytesDer()`.
        ///
        /// We strongly recommend using `toBytesRaw()` or `toBytesDer()` instead.
        ///
        ///
        /// </summary>
        byte[] ToBytes()

        /// <summary>
        ///
        /// Serialize the private key into bytes using SPKI and DER encoding.
        ///
        ///
        /// </summary>
        byte[] ToBytesDer()

        /// <summary>
        ///
        /// Return just the raw bytes for the given key.
        ///
        ///
        /// </summary>
        byte[] ToBytesRaw()

        /// <summary>
        ///
        /// Convert this public key into an evm address. The EVM address is This is the rightmost 20 bytes of the 32 byte Keccak-256 hash of the ECDSA public key.
        ///
        ///
        /// </summary>
        string ToEvmAddress()

        /// <summary>
        ///
        /// See: [`toStringDer()`](#tostringder----string)
        ///
        ///
        /// </summary>
        string ToString()

        /// <summary>
        ///
        /// Encodes [`toBytesDer()`](#tobytesder----bytes) into HEX.
        ///
        /// **Note**: This results in a string which has the key data of the private key prefixed with a header.
        ///
        ///
        /// </summary>
        string ToStringDer()

        /// <summary>
        ///
        /// Encodes [`toBytesRaw()`](#tobytesraw----bytes) into HEX.
        ///
        ///
        /// </summary>
        string ToStringRaw()

        /// <summary>
        ///
        /// Verify the signature on the message with this public key.
        ///
        ///
        /// </summary>
        bool Verify(byte[] message, byte[] signature)

        /// <summary>
        ///
        /// Verify the signatures on all the messages in the Transaction.
        /// </summary>
        bool VerifyTransaction(ITransaction transaction)

    }
}
