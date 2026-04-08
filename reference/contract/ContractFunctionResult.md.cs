using System.Numerics;

namespace Hedera.Hashgraph.Reference.Contract
{
    public interface IContractFunctionResult
    {
        byte[] AsBytes();
        string GetString(long index);
        string[] GetStringArray(long index);
        byte[] GetBytes(long index);
        byte[] GetBytes32(long index);
        byte[] GetDynamicBytes(long index);
        bool GetBool(long index);
        int GetInt8(long index);
        long GetInt32(long index);
        long GetInt64(long index);
        BigInteger GetInt256(long index);
        long GetUint8(long index);
        long GetUint32(long index);
        long GetUint64(long index);
        BigInteger GetUint256(long index);
        string GetAddress(long index);

        /// <summary>
        /// The smart contract instance whose function was called
        /// </summary>
        IContractId ContractId { get; }

        /// <summary>
        /// Message In case there was an error during smart contract execution
        /// </summary>
        string ErrorMessage { get; }

        /// <summary>
        /// Bloom filter for record
        /// </summary>
        byte[] Bloom { get; }

        /// <summary>
        /// Units of gas used to execute contract
        /// </summary>
        long GasUsed { get; }

        /// <summary>
        /// The log info for events returned by the function
        /// </summary>
        IContractLogInfo Logs { get; }

        /// <summary>
        /// The list of smart contracts that were created by the function call
        /// [DEPRECATED] the list of smart contracts that were created by the function call.
        ///
        /// The created ids will now _also_ be externalized through internal transaction
        /// records, where each record has its alias field populated with the new contract's
        /// EVM address. (This is needed for contracts created with CREATE2, since
        /// there is no longer a simple relationship between the new contract's 0.0.X id
        /// and its Solidity address.)
        /// </summary>
        IContractId CreatedContractIds { get; }

        /// <summary>
        /// The list of state reads and changes caused by this function call
        /// </summary>
        IContractStateChange StateChanges { get; }

        /// <summary>
        /// The contracts evm address represented as a contract ID with `ContractId.evmAddress` set accordingly.
        /// </summary>
        IContractId EvmAddress { get; }
    }
}
