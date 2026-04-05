/// <summary>
/// &gt; class `ContractFunctionResult`
/// The smart contract instance whose function was called
/// --
/// Message In case there was an error during smart contract execution
/// --
/// Bloom filter for record
/// --
/// Units of gas used to execute contract
/// --
/// The log info for events returned by the function
/// --
/// The list of smart contracts that were created by the function call
/// [DEPRECATED] the list of smart contracts that were created by the function call.
/// The created ids will now _also_ be externalized through internal transaction
/// records, where each record has its alias field populated with the new contract's
/// EVM address. (This is needed for contracts created with CREATE2, since
/// there is no longer a simple relationship between the new contract's 0.0.X id
/// and its Solidity address.)
/// --
/// The list of state reads and changes caused by this function call
/// --
/// The contracts evm address represented as a contract ID with `ContractId.evmAddress` set accordingly.
/// --
/// --
/// --
/// --
/// --
/// --
/// --
/// --
/// --
/// --
/// --
/// --
/// --
/// --
/// --
/// --
/// --
/// </summary>
public interface IContractFunctionResult
{
}