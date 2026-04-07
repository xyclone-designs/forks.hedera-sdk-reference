namespace Hedera.Hashgraph.Reference.Contract
{
    /// <summary>
    /// </summary>
    public interface IContractExecuteTransaction
    {
        /// <summary>
        ///
        ///
        /// </summary>
        IContractExecuteTransaction SetFunction(string name)

        /// <summary>
        ///
        ///
        /// </summary>
        IContractExecuteTransaction SetFunction(string name, IContractFunctionParameters params)

        /// <summary>
        ///
        /// The `ContractId` if the instance to execute.
        ///
        ///
        /// </summary>
        IContractId ContractId { get; }

        /// <summary>
        ///
        /// The maximum amount of gas to use for the execution.
        ///
        ///
        /// </summary>
        long Gas { get; }

        /// <summary>
        ///
        /// Number of tinybars sent.
        ///
        ///
        /// </summary>
        Hbar PayableAmount { get; }

        /// <summary>
        ///
        /// Which function to execute, and the parameters to pass to the function. Use
        /// [`setFunction(name)`](#setfunction-name-string-contractcallquery) and
        /// [`setFunction(name, params)`](#setfunction-name-string-params-contractfunctionparameters-contractcallquery)
        /// to set this field.
        ///
        ///
        /// </summary>
        byte[] FunctionParameters { get; }

    }
}
