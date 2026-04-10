using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Contract
{
    public interface IContractExecuteTransaction : ITransaction
    {
        IContractExecuteTransaction SetFunction(string name);
        IContractExecuteTransaction SetFunction(string name, IContractFunctionParameters _params);

        /// <summary>
        /// The `ContractId` if the instance to execute.
        /// </summary>
        ContractId ContractId { get; }

        /// <summary>
        /// The maximum amount of gas to use for the execution.
        /// </summary>
        long Gas { get; }

        /// <summary>
        /// Number of tinybars sent.
        /// </summary>
        Hbar PayableAmount { get; }

        /// <summary>
        /// Which function to execute, and the parameters to pass to the function. Use
        /// [`setFunction(name)`](#setfunction-name-string-contractcallquery) and
        /// [`setFunction(name, params)`](#setfunction-name-string-params-contractfunctionparameters-contractcallquery)
        /// to set this field.
        /// </summary>
        byte[] FunctionParameters { get; }

    }
}
