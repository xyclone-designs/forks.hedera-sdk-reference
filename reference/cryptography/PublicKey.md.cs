using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;
using System;

namespace Hedera.Hashgraph.Reference.Cryptography
{
    /// <summary>
    /// A public key on the Hedera™ network.
    /// </summary>
    public interface IPublicKey : IKey
    {
        /// <summary>
        /// Parses a DER encoded Ed25519 or ECDSA public key
        ///
        /// **Note**: The use of raw bytes for an Ed25519 public key is deprecated; use `fromBytesEd25519()` instead.
        /// </summary>
        public static IPublicKey FromBytes(byte[] data) => throw new NotImplementedException();
        /// <summary>
        /// Parses a DER encoded Ed25519 or ECDSA public key
        ///
        /// **Note**: Does **not** support raw bytes; the data provided must be DER encoded.
        /// </summary>
        public static IPublicKey FromBytesDer(byte[] data) => throw new NotImplementedException();
        /// <summary>
        /// Parses an ECDSA public key from either DER encoded or raw bytes.
        /// </summary>
        public static IPublicKey FromBytesEcdsa(byte[] data) => throw new NotImplementedException();
        /// <summary>
        /// Parses an Ed25519 public key from either DER encoded or raw bytes.
        /// </summary>
        public static IPublicKey FromBytesEd25519(byte[] data) => throw new NotImplementedException();
        /// <summary>
        /// Parses a HEX and DER encoded Ed25519 or ECDSA public key
        ///
        /// **Note**: The use of raw bytes for an Ed25519 public key is deprecated; use `fromStringEd25519()` instead.
        /// </summary>
        public static IPublicKey FromString(string text) => throw new NotImplementedException();
        /// <summary>
        /// Parses a HEX and DER encoded Ed25519 or ECDSA public key
        ///
        /// **Note**: Does **not** support raw bytes; the data provided must be DER encoded.
        /// </summary>
        public static IPublicKey FromStringDer(string text) => throw new NotImplementedException();
        /// <summary>
        /// Parses an ECDSA public key from either HEX and DER encoded bytes or just HEX encoded raw bytes.
        /// </summary>
        public static IPublicKey FromStringEcdsa(string text) => throw new NotImplementedException();
        /// <summary>
        /// Parses an Ed25519 public key from either HEX and DER encoded bytes or just HEX encoded raw bytes.
        ///
        /// </summary>
        public static IPublicKey FromStringEd25519(string text) => throw new NotImplementedException();

        /// <summary>
        /// Check if this public key is an ECDSA key.
        /// </summary>
        bool IsECDSA();
        /// <summary>
        /// Check if this public key is an ED25519 key.
        /// </summary>
        bool IsED25519();
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
        /// Serialize the private key into bytes using SPKI and DER encoding.
        /// </summary>
        byte[] ToBytesDer();
        /// <summary>
        /// Return just the raw bytes for the given key.
        /// </summary>
        byte[] ToBytesRaw();
        /// <summary>
        /// Convert this public key into an evm address. The EVM address is This is the rightmost 20 bytes of the 32 byte Keccak-256 hash of the ECDSA public key.
        /// </summary>
        string ToEvmAddress();
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
        /// </summary>
        string ToStringRaw();
        /// <summary>
        /// Convert this public key into an account ID with a given shard and realm.
        /// </summary>
        AccountId ToAccountId(long shard, long realm);

        /// <summary>
        /// Verify the signature on the message with this public key.
        /// </summary>
        bool Verify(byte[] message, byte[] signature);
        /// <summary>
        /// Verify the signatures on all the messages in the Transaction.
        /// </summary>
        bool VerifyTransaction(ITransaction transaction);
    }
}
