using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;

namespace Hedera.Hashgraph.Reference.Contract
{
    /// <summary>
    /// A helper class to create a contract file bytecode directly. This will use
    /// `FileCreateTransaction` and `FileAppendTransaction` as necessary to create the file
    /// followed by `ContractCreateTransaction` to create the contract, and finally
    /// `FileDeleteTransaction` to delete the created file since it's no longer necessary.
    /// </summary>
    public interface IContractCreateFlow
    {
        /// <summary>
        /// The bytecode for the contract
        /// </summary>
        string Bytecode { get; }

        /// <summary>
        /// The state of the instance and its fields can be modified arbitrarily if `adminKey` signs a transaction to modify it.
        /// If this is null, then such modifications are not possible, and there is no administrator that can override the normal operation of this smart contract instance.
        /// Note that if it is created with no admin keys, then there is no administrator to authorize changing the admin keys, so there can never be any admin keys for that instance.
        /// </summary>
        IKey AdminKey { get; }

        /// <summary>
        /// Gas to run the constructor.
        /// </summary>
        long Gas { get; }

        /// <summary>
        /// Initial number of tinybars to put into the cryptocurrency account associated with and owned by the smart contract.
        /// </summary>
        IHbar InitialBalance { get; }

        /// <summary>
        /// `AccountId` of the account to which this account is proxy staked.
        /// If `proxyAccountID` is null, or is an invalid account, or is an account that isn't a node, then this account is automatically proxy staked to a node chosen by the network, but without earning payments.
        /// If the `proxyAccountID` account refuses to accept proxy staking , or if it is not currently running a node, then it will behave as if `proxyAccountID` was null.
        /// </summary>
        IAccountId ProxyAccountId { get; }

        /// <summary>
        /// The instance will charge its account every this many seconds to renew for this long.
        /// </summary>
        Duration AutoRenewPeriod { get; }

        /// <summary>
        /// Parameters to pass to the constructor.
        /// </summary>
        byte[] ConstructorParameters { get; }

        /// <summary>
        /// The memo that was submitted as part of the contract (max 100 bytes).
        /// </summary>
        string ContractMemo { get; }

    }
}
