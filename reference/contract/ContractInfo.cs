/// <summary>
/// &gt; class `ContractInfo`
/// Current information on the smart contract instance, including its balance.
/// Deserialize a [`ContractInfo`](ContractInfo) from its protobuf representation.
/// --
/// Serialize the [`ContractInfo`](ContractInfo) into its protobuf representation.
/// --
/// ID of the cryptocurrency account owned by the contract instance.
/// --
/// The state of the instance and its fields can be modified arbitrarily if `adminKey` signs a transaction to modify it.
/// If this is null, then such modifications are not possible, and there is no administrator that can override the normal operation of this smart contract instance.
/// Note that if it is created with no admin keys, then there is no administrator to authorize changing the admin keys, so there can never be any admin keys for that instance.
/// --
/// ID of the account to charge for auto-renewal of this contract.
/// --
/// The expiration time will extend every this many seconds.
/// If there are insufficient funds, then it extends as long as possible.
/// If the account is empty when it expires, then it is deleted.
/// --
/// The current balance, in tinybars.
/// --
/// ID of both the contract instance and the cryptocurrency account owned by the contract instance, in the format used by Solidity.
/// --
/// ID of the contract instance.
/// --
/// The memo associated with the contract (max 100 bytes).
/// --
/// The current time at which this contract instance (and its account) is set to expire.
/// --
/// Whether the contract has been deleted.
/// --
/// The ID of the ledger which returned this response
/// --
/// Staking metadata for this contract.
/// --
/// Number of bytes of storage being used by this instance (which affects the cost to extend the expiration time).
/// --
/// The tokens associated to the contract.
/// </summary>
public interface IContractInfo
{
}