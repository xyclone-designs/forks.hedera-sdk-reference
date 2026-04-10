using Hedera.Hashgraph.Reference.Core;

namespace Hedera.Hashgraph.Reference.Contract
{
    /// <summary>
    /// Retrieve the latest state of a contract call.
    /// </summary>
    public interface IContractCallQuery : IQuery<IContractFunctionResult>
    {
        IContractCallQuery SetFunction(string name);

        /// <summary>
        /// `Function`: `ContractCallQuery`
        /// ## Properties
        /// </summary>
        IContractCallQuery SetFunction(string name, IContractFunctionParameters _params);

        /// <summary>
        /// The `ContractId` for which information is being requested.
        /// </summary>
        ContractId ContractId();

        /// <summary>
        /// The amount of gas to use for the call.
        /// All of the gas offered will be used and charged a corresponding fee.
        /// </summary>
        long Gas();

        /// <summary>
        /// Which function to call, and the parameters to pass to the function. Use
        /// [`setFunction(name)`](#setfunction-name-string-contractcallquery) and
        /// [`setFunction(name, params)`](#setfunction-name-string-params-contractfunctionparameters-contractcallquery)
        /// to set this field.
        /// </summary>
        byte[] FunctionParameters();

        /// <summary>
        /// Maximum number of bytes that the result might include. The run will fail if it is returning more than this number of bytes.
        /// </summary>
        long MaxResultSize();
    }
}
