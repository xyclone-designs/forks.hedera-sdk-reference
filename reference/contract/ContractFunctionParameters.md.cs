namespace Hedera.Hashgraph.Reference.Contract
{
    /// <summary>
    /// </summary>
    public interface IContractFunctionParameters
    {
        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddString(string param)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddStringArray(string[] strings)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddBytes(byte[] param)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddBytesArray(byte[][] param)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddBytes32(byte[] param)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddBytes32Array(byte[][] param)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddBool(bool bool)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddInt8(byte value)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddInt32(int value)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddInt64(long value)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddInt256(BigInteger value)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddInt8Array(byte[] intArray)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddInt32Array(int[] intArray)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddInt64Array(long[] intArray)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddInt256Array(BigInteger intArray)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddUint8(byte value)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddUint32(int value)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddUint64(long value)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddUint256(BigInteger value)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddUint8Array(byte[] intArray)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddUint32Array(int[] intArray)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddUint64Array(long[] intArray)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddUint256Array(BigInteger[] intArray)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddAddress(string address)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddAddressArray(string[] addresses)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractFunctionParameters AddFunction(string address, byte[] selector)

        /// <summary>
        ///
        /// </summary>
        IContractFunctionParameters AddFunction(string address, IContractFunctionSelector selector)

    }
}
