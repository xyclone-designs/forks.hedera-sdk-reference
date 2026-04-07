namespace Hedera.Hashgraph.Reference
{
    /// <summary>
    /// A helper class to submit ethereum transactions to Hedera. This class will take
    /// care of moving the call data out of the ethereum transaction into a Hedera file
    /// if the size is too large. Current this only supports the "legacy" and EIP1559
    /// ethereum transaction RLP formats. Other formats will error.
    ///
    /// </summary>
    public interface IEthereumFlow
    {
        /// <summary>
        ///
        /// The raw Ethereum transaction (RLP encoded type 0, 1, and 2).
        ///
        ///
        /// </summary>
        EthereumTransactionData? EthereumData { get; }

        /// <summary>
        ///
        /// The maximum amount, in tinybars, that the payer of the hedera transaction
        /// is willing to pay to complete the transaction.
        ///
        /// Ordinarily the account with the ECDSA alias corresponding to the public
        /// key that is extracted from the ethereum\_data signature is responsible for
        /// fees that result from the execution of the transaction. If that amount of
        /// authorized fees is not sufficient then the payer of the transaction can be
        /// charged, up to but not exceeding this amount. If the ethereum\_data
        /// transaction authorized an amount that was insufficient then the payer will
        /// only be charged the amount needed to make up the difference. If the gas
        /// price in the transaction was set to zero then the payer will be assessed
        /// the entire fee.
        ///
        /// </summary>
        Hbar? MaxHbarGasAllowance { get; }

    }
}
