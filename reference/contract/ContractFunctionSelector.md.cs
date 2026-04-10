using System;

namespace Hedera.Hashgraph.Reference.Contract
{
    public interface IContractFunctionSelector
    {
        public static IContractFunctionSelector Constructor(string functionName) => throw new NotImplementedException();

        IContractFunctionSelector AddString();
        IContractFunctionSelector AddStringArray();
        IContractFunctionSelector AddBytes();
        IContractFunctionSelector AddBytesArray();
        IContractFunctionSelector AddBytes32();
        IContractFunctionSelector AddBytes32Array();
        IContractFunctionSelector AddBool();
        IContractFunctionSelector AddInt8();
        IContractFunctionSelector AddInt32();
        IContractFunctionSelector AddInt64();
        IContractFunctionSelector AddInt256();
        IContractFunctionSelector AddInt8Array();
        IContractFunctionSelector AddInt32Array();
        IContractFunctionSelector AddInt64Array();
        IContractFunctionSelector AddInt256Array();
        IContractFunctionSelector AddUint8();
        IContractFunctionSelector AddUint32();
        IContractFunctionSelector AddUint64();
        IContractFunctionSelector AddUint256();
        IContractFunctionSelector AddUint8Array();
        IContractFunctionSelector AddUint32Array();
        IContractFunctionSelector AddUint64Array();
        IContractFunctionSelector AddUint256Array();
        IContractFunctionSelector AddAddress();
        IContractFunctionSelector AddAddressArray();
    }
}
