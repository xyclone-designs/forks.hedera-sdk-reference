using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;
using System;
using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// Managed client for use on the Hedera Hashgraph network.
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// Construct a client for a specific network.
        ///
        /// It is the responsibility of the caller to ensure that all nodes
        /// in the map are part of the same Hedera network. Failure to do
        /// so will result in undefined behavior.
        ///
        /// The client will load balance all requests to Hedera using
        /// a simple round-robin scheme to chose nodes to send transactions
        /// to. For one transaction, at most 1/3 of the nodes will be tried.
        ///
        /// Network constants are made available to use.
        /// </summary>
        abstract static IClient ForNetwork(IDictionary<string, IAccountId> network);

        /// <summary>
        /// Construct a Hedera client pre-configured for Mainnet access.
        ///
        /// Will initially be filled with a hard-coded address book for the consensus node network, but in the background the client will immediately attempt to update its consensus node network using an [`AddressBookQuery`](../network/AddressBookQuery.md) against the mirror network.  If the query fails, the consensus node network will remain unchanged and the query failure will be logged.
        /// </summary>
        abstract static IClient ForMainnet();

        /// <summary>
        /// Construct a Hedera client pre-configured for Testnet access.
        ///
        /// Will initially be filled with a hard-coded address book for the consensus node network, but in the background the client will immediately attempt to update its consensus node network using an [`AddressBookQuery`](../network/AddressBookQuery.md) against the mirror network.  If the query fails, the consensus node network will remain unchanged and the query failure will be logged.
        /// </summary>
        abstract static IClient ForTestnet();

        /// <summary>
        /// Construct a Hedera client pre-configured for Previewnet access.
        ///
        /// Will initially be filled with a hard-coded address book for the consensus node network, but in the background the client will immediately attempt to update its consensus node network using an [`AddressBookQuery`](../network/AddressBookQuery.md) against the mirror network.  If the query fails, the consensus node network will remain unchanged and the query failure will be logged.
        /// </summary>
        abstract static IClient ForPreviewnet();

        /// <summary>
        /// Construct a Hedera client for a given name.
        ///
        /// Valid names are "previewnet", "testnet", "mainnet"
        ///
        /// For a valid name, the behavior is identical to `for[Mainnet|Testnet|Previewnet]()`
        /// </summary>
        abstract static IClient ForName(string name);

        /// <summary>
        /// Configure a client from the JSON configuration string.
        ///
        /// <details>
        /// <summary><b>File Specification</b></summary>
        ///
        /// `network` can be `mainnet`, `testnet`, `previewnet`, or a dictionary of Account
        /// ID to IP:PORT
        ///
        /// ```json
        /// {
        /// "network": "mainnet"
        /// }
        /// ```
        ///
        /// or
        ///
        /// ```json
        /// {
        /// "network": { "0.0.1": "0.testnet.hedera.com:50211" }
        /// }
        /// ```
        ///
        /// `operator` is an _optional_ object
        ///
        /// ```json
        /// {
        /// "operator": {
        /// "accountId": "0.0.21",
        /// "privateKey": "302...."
        /// }
        /// }
        /// ```
        ///
        /// `mirrorNetwork` can be a network name (mainnet, previewnet, etc.) or a list
        /// of addresses. `mirrorNetwork` defaults to the name of `network` _if_ that is
        /// a network name.
        ///
        /// ```json
        /// {
        /// "mirrorNetwork": "mainnet"
        /// }
        /// ```
        ///
        /// or
        ///
        /// ```json
        /// {
        /// "mirrorNetwork": [ "kabuto.sh:50211", "hedera.com:50211" ]
        /// }
        /// ```
        ///
        /// </details>
        /// </summary>
        abstract static IClient FromConfig(string data);

        /// <summary>
        /// Configure a client from the JSON configuration file. The file must have the same structure as the JSON in [`fromConfig`](#fromconfig--data--string---client)
        /// </summary>
        abstract static IClient FromConfigFile(string filename);

        /// <summary>
        /// Close all open connections with the Hedera network; and, release all
        /// associated resources.
        /// </summary>
        void Close();

        /// <summary>
        /// Ping a single node
        ///
        /// **NOTE**: This method will **not** throw if the node doesn't respond with a successful status code,
        /// instead the network will de-prioritize it.
        /// </summary>
        void Ping(IAccountId nodeAccountId);

        /// <summary>
        /// Ping all nodes in the current network.
        ///
        /// **NOTE**: This method will **not** throw if a node doesn't respond with a successful status code,
        /// instead the network will de-prioritize it.
        /// </summary>
        void PingAll();

        /// <summary>
        /// Replaces the current network with one which is given in an `AddressBook` (which presumably was acquired via an [`AddressBookQuery`](../network/AddressBookQuery.md))
        /// </summary>
        void SetNetworkFromAddressBook(AddressBook addressBook);

        /// <summary>
        /// Sets the account that will, by default, pay for transactions and queries built
        /// with this client.
        /// </summary>
        IClient SetOperator(IAccountId accountId, IPrivateKey privateKey);

        /// <summary>
        /// Sets the account that will, by default, pay for transactions and queries built
        /// with this client.
        ///
        /// It is expected that the signing method utilize the private key associated
        /// with the given public key.
        ///
        /// This form is made available for integrating the SDK to sign
        /// from an external source such as the Ledger Hardware Wallet.
        /// </summary>
        IClient SetOperatorWith(IAccountId accountId, IPublicKey publicKey, Func<byte[], byte[]> transactionSigner)

        /// <summary>
        /// Is automatic entity ID checksum validation enabled.
        /// </summary>
        bool AutoValidateChecksums { get; }

        /// <summary>
        /// Maximum amount of time closing a network can take.
        /// </summary>
        Duration CloseTimeout { get; }

        /// <summary>
        /// The maximum query payment.
        ///
        /// **NOTE**: Defaults to 1 Hbar.
        /// </summary>
        IHbar DefaultMaxQueryPayment { get; }

        /// <summary>
        /// The default maximum fee used for transactions.
        /// </summary>
        IHbar DefaultMaxTransactionFee { get; }

        /// <summary>
        /// Declares if we should generate new transaction IDs when a transaction fails with `TRANSACTION_EXPIRED`.
        ///
        /// **NOTE**: Defaults to `true`
        /// </summary>
        bool DefaultRegenerateTransactionId { get; }

        /// <summary>
        /// Current LedgerId of the network; corresponds to ledger ID in entity ID checksum calculations.
        /// </summary>
        ILedgerId LedgerId { get; }

        /// <summary>
        /// Max number of attempts a request executed with this client will do.
        /// </summary>
        long MaxAttempts { get; }

        /// <summary>
        /// The maximum amount of time to wait between retries
        /// </summary>
        Duration MaxBackoff { get; }

        /// <summary>
        /// Max number of times any node in the network can receive a bad gRPC status before being removed from the network.
        /// </summary>
        long MaxNodeAttempts { get; }

        /// <summary>
        /// The minimum amount of time to wait between retries
        /// </summary>
        Duration MinBackoff { get; }

        /// <summary>
        /// The mirror network node list
        /// </summary>
        IList<string> MirrorNetwork { get; }

        /// <summary>
        /// The list of network records
        /// </summary>
        IAccountId Network { get; }

        /// <summary>
        /// If present, the client will periodically attempt to update its consensus node network in the background using
        /// an [`AddressBookQuery`](../network/AddressBookQuery.md) against its current mirror network.
        /// If the query fails, the consensus node network will remain unchanged and the query failure will be logged.
        /// </summary>
        Duration NetworkUpdatePeriod { get; }

        /// <summary>
        /// The ID of the operator
        /// </summary>
        IAccountId? OperatorAccountId { get; }

        /// <summary>
        /// The key of the operator
        /// </summary>
        IPublicKey? OperatorPublicKey { get; }

        /// <summary>
        /// Maximum amount of time a request can run
        /// </summary>
        Duration RequestTimeout { get; }

        /// <summary>
        /// Is certificate verification enabled
        ///
        /// Only available in Java and Go SDKs
        /// </summary>
        bool VerifyCertificates { get; }

    }
}
