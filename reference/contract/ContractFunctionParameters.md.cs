using System.Numerics;

namespace Hedera.Hashgraph.Reference.Contract
{
    public interface IContractFunctionParameters
    {
        IContractFunctionParameters AddString(string param);
        IContractFunctionParameters AddStringArray(string[] strings);
        IContractFunctionParameters AddBytes(byte[] param);
        IContractFunctionParameters AddBytesArray(byte[][] param);
        IContractFunctionParameters AddBytes32(byte[] param);
        IContractFunctionParameters AddBytes32Array(byte[][] param);
        IContractFunctionParameters AddBool(bool value);
        IContractFunctionParameters AddInt8(byte value);
        IContractFunctionParameters AddInt32(int value);
        IContractFunctionParameters AddInt64(long value);
        IContractFunctionParameters AddInt256(BigInteger value);
        IContractFunctionParameters AddInt8Array(byte[] intArray);
        IContractFunctionParameters AddInt32Array(int[] intArray);
        IContractFunctionParameters AddInt64Array(long[] intArray);
        IContractFunctionParameters AddInt256Array(BigInteger intArray);
        IContractFunctionParameters AddUint8(byte value);
        IContractFunctionParameters AddUint32(int value);
        IContractFunctionParameters AddUint64(long value);
        IContractFunctionParameters AddUint256(BigInteger value);
        IContractFunctionParameters AddUint8Array(byte[] intArray);
        IContractFunctionParameters AddUint32Array(int[] intArray);
        IContractFunctionParameters AddUint64Array(long[] intArray);
        IContractFunctionParameters AddUint256Array(BigInteger[] intArray);
        IContractFunctionParameters AddAddress(string address);
        IContractFunctionParameters AddAddressArray(string[] addresses);
        IContractFunctionParameters AddFunction(string address, byte[] selector);
        IContractFunctionParameters AddFunction(string address, IContractFunctionSelector selector);
    }
}
