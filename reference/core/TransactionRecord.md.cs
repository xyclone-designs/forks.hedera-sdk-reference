using Hedera.Hashgraph.Reference.Contract;
using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;
using Hedera.Hashgraph.Reference.Schedule;
using Hedera.Hashgraph.Reference.Token;

using System;
using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Core
{
    /// <summary>
    /// Response when the client sends the node TransactionGetRecordResponse
    /// </summary>
    public class TransactionRecord
    {
        /// <summary>
        /// Decode a `TransactionRecord` from an appropriate protobuf encode structure
        /// </summary>
        public static TransactionRecord FromBytes(byte[] data);
            
        /// <summary>
        /// The byte representation of the encoded protobuf type
        /// </summary>
        byte[] ToBytes();
        /// <summary>
        /// Stringification of all the current values
        /// </summary>
        string ToString();

        /// <summary>
        /// In the record of an internal CryptoCreate transaction triggered by a user transaction with a
        /// (previously unused) alias, the new account's alias.
        /// </summary>
        IPublicKey AliasKey { get; }
        /// <summary>
        /// In the record of an internal transaction, the consensus timestamp of the user transaction that spawned it.
        /// </summary>
        IList<IAssessedCustomFee> AssessedCustomFees { get; }
        /// <summary>
        /// In the record of an internal transaction, the consensus timestamp of the user transaction that spawned it.
        /// </summary>
        IList<ITokenAssociation> AutomaticTokenAssociations { get; }

        /// <summary>
        /// The records of processing all child transaction spawned by the transaction with the given
        /// top-level id, in consensus order.Always empty if the top-level status is UNKNOWN.
        /// </summary>
        ITransactionRecord Children { get; }

        /// <summary>
        /// The timestamp the transaction came to consensus
        /// </summary>
        DateTimeOffset ConsensusDateTimeOffset { get; }
        /// <summary>
        /// Result of a ContractExecuteTransaction
        /// </summary>
        IContractFunctionResult? ContractFunctionResult { get; }

        /// <summary>
        /// The records of processing all consensus transaction with the same id as the distinguished record above, in chronological order.
        /// </summary>
        ITransactionRecord Duplicates { get; }

        /// <summary>
        /// The keccak256 hash of the ethereumData.

        /// **NOTE**: This field will only be populated for EthereumTransaction.
        /// </summary>
        byte[] EthereumHash { get; }

        /// <summary>
        /// The EOA 20-byte address to create that is derived from the keccak-256 hash of a ECDSA_SECP256K1 primitive key.
        /// </summary>
        byte[] EvmAddress { get; }

        /// <summary>
        /// List of accounts with the corresponding staking rewards paid as a result of a transaction.
        /// </summary>
        ITransfer PaidStakingRewards { get; }

        /// <summary>
        /// In the record of an internal transaction, the consensus timestamp of the user transaction that spawned it.
        /// </summary>
        DateTimeOffset ParentConsensusDateTimeOffset { get; }

        /// <summary>
        /// In the record of a UtilPrng transaction with no output range, a pseudorandom 384-bit string.
        /// </summary>
        byte[] PrngBytes { get; }

        /// <summary>
        /// In the record of a PRNG transaction with an output range, the output of a PRNG whose input was a 384-bit string.
        /// </summary>
        uint PrngNumber { get; }

        /// <summary>
        /// Receipt for the transaction
        /// </summary>
        ITransactionReceipt Receipt { get; }

        /// <summary>
        /// In the record of an internal transaction, the consensus timestamp of the user transaction that spawned it.
        /// </summary>
        IScheduleId ScheduleRef { get; }

        /// <summary>
        /// All NFT Token transfers as a result of this transaction
        /// </summary>
        IDictionary<TokenId, IList<ITokenNftTransfer>> TokenNftTransfers { get; }

        /// <summary>
        /// All fungible token transfers as a result of this transaction as a list
        /// </summary>
        IList<ITokenTransfer> TokenTransferList { get; }

        /// <summary>
        /// Any token transfers made in this transaction
        ///
        /// ** Note**: These token transfers are different from the ones set in [`TransferTransaction`] (../cryptocurrency/TransferTransaction.md)
        /// </summary>
        IDictionary<TokenId, IList<AccountId>> TokenTransfers { get; }

        /// <summary>
        /// Fee set on the transaction
        /// </summary>
        Hbar TransactionFee { get; }

        /// <summary>
        /// Hash of the transaction
        /// </summary>
        byte[] TransactionHash { get; }

        /// <summary>
        /// Transaction ID of the transaction
        /// </summary>
        TransactionId TransactionId { get; }

        /// <summary>
        /// Memo set on the transaction
        /// </summary>
        string TransactionMemo { get; }

        /// <summary>
        /// Any transfers made in this transaction

        /// ** Note**: Includes fee payments
        /// </summary>
        ITransfer[] Transfers { get; } 
    }
}
