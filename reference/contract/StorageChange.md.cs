using System;
using System.Numerics;

namespace Hedera.Hashgraph.Reference.Contract
{
    public class StorageChange
    {
        public StorageChange(BigInteger slot, BigInteger valueRead, BigInteger valueWritten)
        {
            Slot = slot;
            ValueRead = valueRead;
            ValueWritten = valueWritten;
        }

        /// <summary>
        /// Deserialize a [`StorageChange`](#) from its protobuf representation.
        /// </summary>
        public static StorageChange FromBytes(byte[] data)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Serialize the [`StorageChange`](#) into its protobuf representation.
        /// </summary>
        public virtual byte[] ToBytes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The storage slot changed.  Up to 32 bytes, big-endian, zero bytes left trimmed.
        /// </summary>
        public BigInteger Slot { get; }
        /// <summary>
        /// The value read from the storage slot.  Up to 32 bytes, big-endian, zero bytes left trimmed.
        /// Because of the way SSTORE operations are charged the slot is always read before being written to.
        /// </summary>
        public BigInteger ValueRead { get; }
        /// <summary>
        /// The new value written to the slot.  Up to 32 bytes, big-endian, zero bytes left trimmed.
        /// If a value of zero is written the valueWritten will be present but the inner value will be absent.
        /// If a value was read and not written this value will not be present.
        /// </summary>
        public BigInteger? ValueWritten { get; }
    }
}
