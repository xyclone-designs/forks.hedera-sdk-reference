/// <summary>
/// &gt; class `ClientConfig`
/// The config file specification for [`Client`](Client.md) construction
/// The custom network map
/// The key is the address and the value is the serialized form of
/// [`AccountId`](../cryptocurrency/AccountId.md)
/// --
/// The name of the network
/// Valid values are "previewnet", "testnet", or "mainnet"
/// --
/// The custom mirror network list
/// Each value in the list is the address to a mirror node
/// --
/// The name of the mirror network
/// Valid values are "previewnet", "testnet", or "mainnet"
/// --
/// The operator for the given client
/// --
/// Set the name of the given network.
/// Useful when `network` is a custom network map
/// </summary>
public interface IClientConfig
{
}