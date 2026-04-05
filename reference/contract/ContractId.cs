/// <summary>
/// &gt; class `ContractId` extends [`Key`](../cryptography/Key.md)
/// An ID type that represents a contract on a Hedera Hashgraph network.
/// Construct a [`ContractId`](ContractId) with [`shard`](#shard--uint64) and [`realm`](#realm--uint64) being zero.
/// --
/// Construct a [`ContractId`](ContractId) with all fields explicitly set.
/// --
/// Deserialize a [`ContractId`](ContractId) from its protobuf representation.
/// --
/// Construct a [`ContractId`](ContractId) from a shard, realm, and evm address.
/// --
/// Construct a [`ContractId`](ContractId) a solidity address.
/// Deprecated: Use `fromEvmAddress()` instead.
/// --
/// Construct a [`ContractId`](ContractId) from a string. The format of the string could be either just
/// a number "4" or dot separated numbers "0.0.4".
/// --
/// Serialize the [`ContractId`](ContractId) into its protobuf representation.
/// --
/// Serialize the [`ContractId`](ContractId) into a string form which follows `{shard}.{realm}.{num}` if `evmAddress` is not present
/// and `{shard}.{realm}.{evmAddress}` if `evmAddress` is present.
/// --
/// Serialize the [`ContractId`](ContractId) into its solidity address form.
/// --
/// The evm address of this contract.
/// Note: This field is only set when `fromEvmAddress()` is used. `fromSolidityAddress()` does not populate this field
/// --
/// The num of this ID.
/// --
/// The realm of this ID.
/// --
/// The shard of this ID.
/// </summary>
public interface IContractId
{
}