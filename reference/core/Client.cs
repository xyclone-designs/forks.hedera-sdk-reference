/// <summary>
/// &gt; class `Client`
/// Managed client for use on the Hedera Hashgraph network.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// // create from..
/// var network = new HashMap&lt;String, AccountId&gt;();
/// network.put("0.testnet.hedera.com:50211", new AccountId(3));
/// var client = Client.forMainnet(); // pre-defined
/// var client = Client.forNetwork(network); // custom network
/// var client = Client.fromConfigFile("./client-config.json"); // configuration file
/// var client = Client.forName("testnet"); // named
/// // set operator (to use to pay transaction fees)
/// client.setOperator(operatorAccountId, operatorPrivateKey);
/// ```
/// ```javascript
/// // create from..
/// const network = {
/// "0.testnet.hedera.com:50211": "0.0.3"
/// };
/// const client = Client.forMainnet(); // pre-defined
/// const client = Client.forNetwork(network); // custom network
/// const client = Client.fromConfigFile("./client-config.json"); // configuration file
/// const client = Client.forName("testnet"); // named
/// // set operator (to use to pay transaction fees)
/// client.setOperator(operatorAccountId, operatorPrivateKey);
/// ```
/// ```go
/// // create from..
/// network := make(map[string]AccountID)
/// network["0.testnet.hedera.com:50211"] = AccountID{Account: 3}
/// client := ClientForMainnet(); // pre-defined
/// client := ClientForNetwork(network); // custom network
/// client, err := ClientFromConfigFile("./client-config.json"); // configuration file
/// client, err := ClientForName("testnet"); // named
/// // set operator (to use to pay transaction fees)
/// client.setOperator(operatorAccountId, operatorPrivateKey);
/// ```
/// &lt;!-- tabs:end --&gt;
/// Construct a client for a specific network.
/// It is the responsibility of the caller to ensure that all nodes
/// in the map are part of the same Hedera network. Failure to do
/// so will result in undefined behavior.
/// The client will load balance all requests to Hedera using
/// a simple round-robin scheme to chose nodes to send transactions
/// to. For one transaction, at most 1/3 of the nodes will be tried.
/// Network constants are made available to use.
/// --
/// Construct a Hedera client pre-configured for Mainnet access.
/// Will initially be filled with a hard-coded address book for the consensus node network, but in the background the client will immediately attempt to update its consensus node network using an [`AddressBookQuery`](../network/AddressBookQuery.md) against the mirror network.  If the query fails, the consensus node network will remain unchanged and the query failure will be logged.
/// --
/// Construct a Hedera client pre-configured for Testnet access.
/// Will initially be filled with a hard-coded address book for the consensus node network, but in the background the client will immediately attempt to update its consensus node network using an [`AddressBookQuery`](../network/AddressBookQuery.md) against the mirror network.  If the query fails, the consensus node network will remain unchanged and the query failure will be logged.
/// --
/// Construct a Hedera client pre-configured for Previewnet access.
/// Will initially be filled with a hard-coded address book for the consensus node network, but in the background the client will immediately attempt to update its consensus node network using an [`AddressBookQuery`](../network/AddressBookQuery.md) against the mirror network.  If the query fails, the consensus node network will remain unchanged and the query failure will be logged.
/// --
/// Construct a Hedera client for a given name.
/// Valid names are "previewnet", "testnet", "mainnet"
/// For a valid name, the behavior is identical to `for[Mainnet|Testnet|Previewnet]()`
/// --
/// Configure a client from the JSON configuration string.
/// &lt;details&gt;
/// &lt;summary&gt;&lt;b&gt;File Specification&lt;/b&gt;&lt;/summary&gt;
/// `network` can be `mainnet`, `testnet`, `previewnet`, or a dictionary of Account
/// ID to IP:PORT
/// ```json
/// {
/// "network": "mainnet"
/// }
/// ```
/// or
/// ```json
/// {
/// "network": { "0.0.1": "0.testnet.hedera.com:50211" }
/// }
/// ```
/// `operator` is an _optional_ object
/// ```json
/// {
/// "operator": {
/// "accountId": "0.0.21",
/// "privateKey": "302...."
/// }
/// }
/// ```
/// `mirrorNetwork` can be a network name (mainnet, previewnet, etc.) or a list
/// of addresses. `mirrorNetwork` defaults to the name of `network` _if_ that is
/// a network name.
/// ```json
/// {
/// "mirrorNetwork": "mainnet"
/// }
/// ```
/// or
/// ```json
/// {
/// "mirrorNetwork": [ "kabuto.sh:50211", "hedera.com:50211" ]
/// }
/// ```
/// &lt;/details&gt;
/// --
/// Configure a client from the JSON configuration file. The file must have the same structure as the JSON in [`fromConfig`](#fromconfig--data--string---client)
/// --
/// Close all open connections with the Hedera network; and, release all
/// associated resources.
/// --
/// Ping a single node
/// **NOTE**: This method will **not** throw if the node doesn't respond with a successful status code,
/// instead the network will de-prioritize it.
/// --
/// Ping all nodes in the current network.
/// **NOTE**: This method will **not** throw if a node doesn't respond with a successful status code,
/// instead the network will de-prioritize it.
/// --
/// Replaces the current network with one which is given in an `AddressBook` (which presumably was acquired via an [`AddressBookQuery`](../network/AddressBookQuery.md))
/// --
/// Sets the account that will, by default, pay for transactions and queries built
/// with this client.
/// --
/// Sets the account that will, by default, pay for transactions and queries built
/// with this client.
/// It is expected that the signing method utilize the private key associated
/// with the given public key.
/// This form is made available for integrating the SDK to sign
/// from an external source such as the Ledger Hardware Wallet.
/// --
/// Is automatic entity ID checksum validation enabled.
/// --
/// Maximum amount of time closing a network can take.
/// --
/// The maximum query payment.
/// **NOTE**: Defaults to 1 Hbar.
/// --
/// The default maximum fee used for transactions.
/// --
/// Declares if we should generate new transaction IDs when a transaction fails with `TRANSACTION_EXPIRED`.
/// **NOTE**: Defaults to `true`
/// --
/// Current LedgerId of the network; corresponds to ledger ID in entity ID checksum calculations.
/// --
/// Max number of attempts a request executed with this client will do.
/// --
/// The maximum amount of time to wait between retries
/// --
/// Max number of times any node in the network can receive a bad gRPC status before being removed from the network.
/// --
/// The minimum amount of time to wait between retries
/// --
/// The mirror network node list
/// --
/// The list of network records
/// --
/// If present, the client will periodically attempt to update its consensus node network in the background using
/// an [`AddressBookQuery`](../network/AddressBookQuery.md) against its current mirror network.
/// If the query fails, the consensus node network will remain unchanged and the query failure will be logged.
/// --
/// The ID of the operator
/// --
/// The key of the operator
/// --
/// Maximum amount of time a request can run
/// --
/// Is certificate verification enabled
/// Only available in Java and Go SDKs
/// </summary>
public interface IClient
{
}