/// <summary>
/// &gt; class `TransactionRecord`
/// Response when the client sends the node TransactionGetRecordResponse
/// Decode a `TransactionRecord` from an appropriate protobuf encode structure
/// --
/// The byte representation of the encoded protobuf type
/// --
/// Stringification of all the current values
/// --
/// In the record of an internal CryptoCreate transaction triggered by a user transaction with a
/// (previously unused) alias, the new account's alias.
/// --
/// In the record of an internal transaction, the consensus timestamp of the user transaction that spawned it.
/// --
/// In the record of an internal transaction, the consensus timestamp of the user transaction that spawned it.
/// --
/// The records of processing all child transaction spawned by the transaction with the given
/// top-level id, in consensus order. Always empty if the top-level status is UNKNOWN.
/// --
/// The timestamp the transaction came to consensus
/// --
/// Result of a [`ContractExecuteTransaction`](../contract/ContractExecuteTransaction.md)
/// --
/// The records of processing all consensus transaction with the same id as the distinguished
/// record above, in chronological order.
/// --
/// The keccak256 hash of the ethereumData.
/// **NOTE**: This field will only be populated for EthereumTransaction.
/// --
/// The EOA 20-byte address to create that is derived from the keccak-256 hash of a ECDSA_SECP256K1 primitive key.
/// --
/// List of accounts with the corresponding staking rewards paid as a result of a transaction.
/// --
/// In the record of an internal transaction, the consensus timestamp of the user transaction that spawned it.
/// --
/// In the record of a UtilPrng transaction with no output range, a pseudorandom 384-bit string.
/// --
/// In the record of a PRNG transaction with an output range, the output of a PRNG whose input was a 384-bit string.
/// --
/// Receipt for the transaction
/// --
/// In the record of an internal transaction, the consensus timestamp of the user transaction that spawned it.
/// --
/// All NFT Token transfers as a result of this transaction
/// --
/// All fungible token transfers as a result of this transaction as a list
/// --
/// Any token transfers made in this transaction
/// **Note**: These token transfers are different from the ones set in [`TransferTransaction`](../cryptocurrency/TransferTransaction.md)
/// --
/// Fee set on the transaction
/// --
/// Hash of the transaction
/// --
/// Transaction ID of the transaction
/// --
/// Memo set on the transaction
/// --
/// Any transfers made in this transaction
/// **Note**: Includes fee payments
/// </summary>
public interface ITransactionRecord
{
}