// SPDX-License-Identifier: Apache-2.0

namespace Hedera.Hashgraph.Reference
{
    public enum Status
    {
        /// <summary>
        /// The transaction passed the precheck validations.
        /// </summary>
        OK,

        /// <summary>
        /// For any error not handled by specific error codes listed below.
        /// </summary>
        INVALID_TRANSACTION,

        /// <summary>
        /// Payer account does not exist.
        /// </summary>
        PAYER_ACCOUNT_NOT_FOUND,

        /// <summary>
        /// Node Account provided does not match the node account of the node the transaction was submitted
        /// to.
        /// </summary>
        INVALID_NODE_ACCOUNT,

        /// <summary>
        /// Pre-Check error when TransactionValidStart + transactionValidTimeSpan is less than current
        /// consensus time.
        /// </summary>
        TRANSACTION_EXPIRED,

        /// <summary>
        /// Transaction start time is greater than current consensus time
        /// </summary>
        INVALID_TRANSACTION_START,

        /// <summary>
        /// The given transactionValidTimeSpan was either non-positive, or greater than the maximum
        /// valid duration of 180 secs.
        /// </summary>
        INVALID_TRANSACTION_DURATION,

        /// <summary>
        /// The transaction signature is not valid
        /// </summary>
        INVALID_SIGNATURE,

        /// <summary>
        /// Transaction memo size exceeded 100 bytes
        /// </summary>
        MEMO_TOO_LONG,

        /// <summary>
        /// The fee provided in the transaction is insufficient for this type of transaction
        /// </summary>
        INSUFFICIENT_TX_FEE,

        /// <summary>
        /// The payer account has insufficient cryptocurrency to pay the transaction fee
        /// </summary>
        INSUFFICIENT_PAYER_BALANCE,

        /// <summary>
        /// This transaction ID is a duplicate of one that was submitted to this node or reached consensus
        /// in the last 180 seconds (receipt period)
        /// </summary>
        DUPLICATE_TRANSACTION,

        /// <summary>
        /// If API is throttled out
        /// </summary>
        BUSY,

        /// <summary>
        /// The API is not currently supported
        /// </summary>
        NOT_SUPPORTED,

        /// <summary>
        /// The file id is invalid or does not exist
        /// </summary>
        INVALID_FILE_ID,

        /// <summary>
        /// The account id is invalid or does not exist
        /// </summary>
        INVALID_ACCOUNT_ID,

        /// <summary>
        /// The contract id is invalid or does not exist
        /// </summary>
        INVALID_CONTRACT_ID,

        /// <summary>
        /// Transaction id is not valid
        /// </summary>
        INVALID_TRANSACTION_ID,

        /// <summary>
        /// Receipt for given transaction id does not exist
        /// </summary>
        RECEIPT_NOT_FOUND,

        /// <summary>
        /// Record for given transaction id does not exist
        /// </summary>
        RECORD_NOT_FOUND,

        /// <summary>
        /// The solidity id is invalid or entity with this solidity id does not exist
        /// </summary>
        INVALID_SOLIDITY_ID,

        /// <summary>
        /// The responding node has submitted the transaction to the network. Its final status is still
        /// unknown.
        /// </summary>
        UNKNOWN,

        /// <summary>
        /// The transaction succeeded
        /// </summary>
        SUCCESS,

        /// <summary>
        /// There was a system error and the transaction failed because of invalid request parameters.
        /// </summary>
        FAIL_INVALID,

        /// <summary>
        /// There was a system error while performing fee calculation, reserved for future.
        /// </summary>
        FAIL_FEE,

        /// <summary>
        /// There was a system error while performing balance checks, reserved for future.
        /// </summary>
        FAIL_BALANCE,

        /// <summary>
        /// Key not provided in the transaction body
        /// </summary>
        KEY_REQUIRED,

        /// <summary>
        /// Unsupported algorithm/encoding used for keys in the transaction
        /// </summary>
        BAD_ENCODING,

        /// <summary>
        /// When the account balance is not sufficient for the transfer
        /// </summary>
        INSUFFICIENT_ACCOUNT_BALANCE,

        /// <summary>
        /// During an update transaction when the system is not able to find the Users Solidity address
        /// </summary>
        INVALID_SOLIDITY_ADDRESS,

        /// <summary>
        /// Not enough gas was supplied to execute transaction
        /// </summary>
        INSUFFICIENT_GAS,

        /// <summary>
        /// contract byte code size is over the limit
        /// </summary>
        CONTRACT_SIZE_LIMIT_EXCEEDED,

        /// <summary>
        /// local execution (query) is requested for a function which changes state
        /// </summary>
        LOCAL_CALL_MODIFICATION_EXCEPTION,

        /// <summary>
        /// Contract REVERT OPCODE executed
        /// </summary>
        CONTRACT_REVERT_EXECUTED,

        /// <summary>
        /// For any contract execution related error not handled by specific error codes listed above.
        /// </summary>
        CONTRACT_EXECUTION_EXCEPTION,

        /// <summary>
        /// In Query validation, account with +ve(amount) value should be Receiving node account, the
        /// receiver account should be only one account in the list
        /// </summary>
        INVALID_RECEIVING_NODE_ACCOUNT,

        /// <summary>
        /// Header is missing in Query request
        /// </summary>
        MISSING_QUERY_HEADER,

        /// <summary>
        /// The update of the account failed
        /// </summary>
        ACCOUNT_UPDATE_FAILED,

        /// <summary>
        /// Provided key encoding was not supported by the system
        /// </summary>
        INVALID_KEY_ENCODING,

        /// <summary>
        /// null solidity address
        /// </summary>
        NULL_SOLIDITY_ADDRESS,

        /// <summary>
        /// update of the contract failed
        /// </summary>
        CONTRACT_UPDATE_FAILED,

        /// <summary>
        /// the query header is invalid
        /// </summary>
        INVALID_QUERY_HEADER,

        /// <summary>
        /// Invalid fee submitted
        /// </summary>
        INVALID_FEE_SUBMITTED,

        /// <summary>
        /// Payer signature is invalid
        /// </summary>
        INVALID_PAYER_SIGNATURE,

        /// <summary>
        /// The keys were not provided in the request.
        /// </summary>
        KEY_NOT_PROVIDED,

        /// <summary>
        /// Expiration time provided in the transaction was invalid.
        /// </summary>
        INVALID_EXPIRATION_TIME,

        /// <summary>
        /// WriteAccess Control Keys are not provided for the file
        /// </summary>
        NO_WACL_KEY,

        /// <summary>
        /// The contents of file are provided as empty.
        /// </summary>
        FILE_CONTENT_EMPTY,

        /// <summary>
        /// The crypto transfer credit and debit do not sum equal to 0
        /// </summary>
        INVALID_ACCOUNT_AMOUNTS,

        /// <summary>
        /// Transaction body provided is empty
        /// </summary>
        EMPTY_TRANSACTION_BODY,

        /// <summary>
        /// Invalid transaction body provided
        /// </summary>
        INVALID_TRANSACTION_BODY,

        /// <summary>
        /// the type of key (base ed25519 key, KeyList, or ThresholdKey) does not match the type of
        /// signature (base ed25519 signature, SignatureList, or ThresholdKeySignature)
        /// </summary>
        INVALID_SIGNATURE_TYPE_MISMATCHING_KEY,

        /// <summary>
        /// the number of key (KeyList, or ThresholdKey) does not match that of signature (SignatureList,
        /// or ThresholdKeySignature). e.g. if a keyList has 3 base keys, then the corresponding
        /// signatureList should also have 3 base signatures.
        /// </summary>
        INVALID_SIGNATURE_COUNT_MISMATCHING_KEY,

        /// <summary>
        /// the livehash body is empty
        /// </summary>
        EMPTY_LIVE_HASH_BODY,

        /// <summary>
        /// the livehash data is missing
        /// </summary>
        EMPTY_LIVE_HASH,

        /// <summary>
        /// the keys for a livehash are missing
        /// </summary>
        EMPTY_LIVE_HASH_KEYS,

        /// <summary>
        /// the livehash data is not the output of a SHA-384 digest
        /// </summary>
        INVALID_LIVE_HASH_SIZE,

        /// <summary>
        /// the query body is empty
        /// </summary>
        EMPTY_QUERY_BODY,

        /// <summary>
        /// the crypto livehash query is empty
        /// </summary>
        EMPTY_LIVE_HASH_QUERY,

        /// <summary>
        /// the livehash is not present
        /// </summary>
        LIVE_HASH_NOT_FOUND,

        /// <summary>
        /// the account id passed has not yet been created.
        /// </summary>
        ACCOUNT_ID_DOES_NOT_EXIST,

        /// <summary>
        /// the livehash already exists for a given account
        /// </summary>
        LIVE_HASH_ALREADY_EXISTS,

        /// <summary>
        /// File WACL keys are invalid
        /// </summary>
        INVALID_FILE_WACL,

        /// <summary>
        /// Serialization failure
        /// </summary>
        SERIALIZATION_FAILED,

        /// <summary>
        /// The size of the Transaction is greater than transactionMaxBytes
        /// </summary>
        TRANSACTION_OVERSIZE,

        /// <summary>
        /// The Transaction has more than 50 levels
        /// </summary>
        TRANSACTION_TOO_MANY_LAYERS,

        /// <summary>
        /// Contract is marked as deleted
        /// </summary>
        CONTRACT_DELETED,

        /// <summary>
        /// the platform node is either disconnected or lagging behind.
        /// </summary>
        PLATFORM_NOT_ACTIVE,

        /// <summary>
        /// one public key matches more than one prefixes on the signature map
        /// </summary>
        KEY_PREFIX_MISMATCH,

        /// <summary>
        /// transaction not created by platform due to large backlog
        /// </summary>
        PLATFORM_TRANSACTION_NOT_CREATED,

        /// <summary>
        /// auto renewal period is not a positive number of seconds
        /// </summary>
        INVALID_RENEWAL_PERIOD,

        /// <summary>
        /// the response code when a smart contract id is passed for a crypto API request
        /// </summary>
        INVALID_PAYER_ACCOUNT_ID,

        /// <summary>
        /// the account has been marked as deleted
        /// </summary>
        ACCOUNT_DELETED,

        /// <summary>
        /// the file has been marked as deleted
        /// </summary>
        FILE_DELETED,

        /// <summary>
        /// same accounts repeated in the transfer account list
        /// </summary>
        ACCOUNT_REPEATED_IN_ACCOUNT_AMOUNTS,

        /// <summary>
        /// attempting to set negative balance value for crypto account
        /// </summary>
        SETTING_NEGATIVE_ACCOUNT_BALANCE,

        /// <summary>
        /// when deleting smart contract that has crypto balance either transfer account or transfer smart
        /// contract is required
        /// </summary>
        OBTAINER_REQUIRED,

        /// <summary>
        /// when deleting smart contract that has crypto balance you can not use the same contract id as
        /// transferContractId as the one being deleted
        /// </summary>
        OBTAINER_SAME_CONTRACT_ID,

        /// <summary>
        /// transferAccountId or transferContractId specified for contract delete does not exist
        /// </summary>
        OBTAINER_DOES_NOT_EXIST,

        /// <summary>
        /// attempting to modify (update or delete a immutable smart contract, i.e. one created without a
        /// admin key)
        /// </summary>
        MODIFYING_IMMUTABLE_CONTRACT,

        /// <summary>
        /// Unexpected exception thrown by file system functions
        /// </summary>
        FILE_SYSTEM_EXCEPTION,

        /// <summary>
        /// the duration is not a subset of [MINIMUM\_AUTORENEW\_DURATION,MAXIMUM\_AUTORENEW\_DURATION]
        /// </summary>
        AUTORENEW_DURATION_NOT_IN_RANGE,

        /// <summary>
        /// Decoding the smart contract binary to a byte array failed. Check that the input is a valid hex
        /// string.
        /// </summary>
        ERROR_DECODING_BYTESTRING,

        /// <summary>
        /// File to create a smart contract was of length zero
        /// </summary>
        CONTRACT_FILE_EMPTY,

        /// <summary>
        /// Bytecode for smart contract is of length zero
        /// </summary>
        CONTRACT_BYTECODE_EMPTY,

        /// <summary>
        /// Attempt to set negative initial balance
        /// </summary>
        INVALID_INITIAL_BALANCE,

        /// <summary>
        /// [Deprecated]. attempt to set negative receive record threshold
        /// </summary>
        INVALID_RECEIVE_RECORD_THRESHOLD,

        /// <summary>
        /// [Deprecated]. attempt to set negative send record threshold
        /// </summary>
        INVALID_SEND_RECORD_THRESHOLD,

        /// <summary>
        /// Special Account Operations should be performed by only Genesis account, return this code if it
        /// is not Genesis Account
        /// </summary>
        ACCOUNT_IS_NOT_GENESIS_ACCOUNT,

        /// <summary>
        /// The fee payer account doesn't have permission to submit such Transaction
        /// </summary>
        PAYER_ACCOUNT_UNAUTHORIZED,

        /// <summary>
        /// FreezeTransactionBody is invalid
        /// </summary>
        INVALID_FREEZE_TRANSACTION_BODY,

        /// <summary>
        /// FreezeTransactionBody does not exist
        /// </summary>
        FREEZE_TRANSACTION_BODY_NOT_FOUND,

        /// <summary>
        /// Exceeded the number of accounts (both from and to) allowed for crypto transfer list
        /// </summary>
        TRANSFER_LIST_SIZE_LIMIT_EXCEEDED,

        /// <summary>
        /// Smart contract result size greater than specified maxResultSize
        /// </summary>
        RESULT_SIZE_LIMIT_EXCEEDED,

        /// <summary>
        /// The payer account is not a special account(account 0.0.55)
        /// </summary>
        NOT_SPECIAL_ACCOUNT,

        /// <summary>
        /// Negative gas was offered in smart contract call
        /// </summary>
        CONTRACT_NEGATIVE_GAS,

        /// <summary>
        /// Negative value / initial balance was specified in a smart contract call / create
        /// </summary>
        CONTRACT_NEGATIVE_VALUE,

        /// <summary>
        /// Failed to update fee file
        /// </summary>
        INVALID_FEE_FILE,

        /// <summary>
        /// Failed to update exchange rate file
        /// </summary>
        INVALID_EXCHANGE_RATE_FILE,

        /// <summary>
        /// Payment tendered for contract local call cannot cover both the fee and the gas
        /// </summary>
        INSUFFICIENT_LOCAL_CALL_GAS,

        /// <summary>
        /// Entities with Entity ID below 1000 are not allowed to be deleted
        /// </summary>
        ENTITY_NOT_ALLOWED_TO_DELETE,

        /// <summary>
        /// Violating one of these rules: 1) treasury account can update all entities below 0.0.1000, 2)
        /// account 0.0.50 can update all entities from 0.0.51 - 0.0.80, 3) Network Function Master Account
        /// A/c 0.0.50 - Update all Network Function accounts & perform all the Network Functions listed
        /// below, 4) Network Function Accounts: i) A/c 0.0.55 - Update Address Book files (0.0.101/102),
        /// ii) A/c 0.0.56 - Update Fee schedule (0.0.111), iii) A/c 0.0.57 - Update Exchange Rate
        /// (0.0.112).
        /// </summary>
        AUTHORIZATION_FAILED,

        /// <summary>
        /// Fee Schedule Proto uploaded but not valid (append or update is required)
        /// </summary>
        FILE_UPLOADED_PROTO_INVALID,

        /// <summary>
        /// Fee Schedule Proto uploaded but not valid (append or update is required)
        /// </summary>
        FILE_UPLOADED_PROTO_NOT_SAVED_TO_DISK,

        /// <summary>
        /// Fee Schedule Proto File Part uploaded
        /// </summary>
        FEE_SCHEDULE_FILE_PART_UPLOADED,

        /// <summary>
        /// The change on Exchange Rate exceeds Exchange\_Rate\_Allowed\_Percentage
        /// </summary>
        EXCHANGE_RATE_CHANGE_LIMIT_EXCEEDED,

        /// <summary>
        /// Contract permanent storage exceeded the currently allowable limit
        /// </summary>
        MAX_CONTRACT_STORAGE_EXCEEDED,

        /// <summary>
        /// Transfer Account should not be same as Account to be deleted
        /// </summary>
        TRANSFER_ACCOUNT_SAME_AS_DELETE_ACCOUNT,

        /// <summary>
        /// </summary>
        EXPIRATION_REDUCTION_NOT_ALLOWED,

        /// <summary>
        /// The expiration date/time on a smart contract may not be reduced
        /// </summary>
        TOTAL_LEDGER_BALANCE_INVALID,

        /// <summary>
        /// Gas exceeded currently allowable gas limit per transaction
        /// </summary>
        MAX_GAS_LIMIT_EXCEEDED,

        /// <summary>
        /// File size exceeded the currently allowable limit
        /// </summary>
        MAX_FILE_SIZE_EXCEEDED,

        /// <summary>
        /// When a valid signature is not provided for operations on account with receiverSigRequired=true
        /// </summary>
        RECEIVER_SIG_REQUIRED,

        /// <summary>
        /// The Topic ID specified is not in the system.
        /// </summary>
        INVALID_TOPIC_ID,

        /// <summary>
        /// A provided admin key was invalid.
        /// </summary>
        INVALID_ADMIN_KEY,

        /// <summary>
        /// A provided submit key was invalid.
        /// </summary>
        INVALID_SUBMIT_KEY,

        /// <summary>
        /// An attempted operation was not authorized (ie - a deleteTopic for a topic with no adminKey).
        /// </summary>
        UNAUTHORIZED,

        /// <summary>
        /// A ConsensusService message is empty.
        /// </summary>
        INVALID_TOPIC_MESSAGE,

        /// <summary>
        /// The autoRenewAccount specified is not a valid, active account.
        /// </summary>
        INVALID_AUTORENEW_ACCOUNT,

        /// <summary>
        /// An adminKey was not specified on the topic, so there must not be an autoRenewAccount.
        /// </summary>
        AUTORENEW_ACCOUNT_NOT_ALLOWED,

        /// <summary>
        /// The topic has expired, was not automatically renewed, and is in a 7 day grace period before the
        /// topic will be deleted unrecoverably. This error response code will not be returned until
        /// autoRenew functionality is supported by HAPI.
        /// </summary>
        TOPIC_EXPIRED,

        /// <summary>
        /// chunk number must be from 1 to total (chunks) inclusive.
        /// </summary>
        INVALID_CHUNK_NUMBER,

        /// <summary>
        /// For every chunk, the payer account that is part of initialTransactionID must match the Payer Account
        /// of this transaction. The entire initialTransactionID should match the transactionID of the first
        /// chunk, but this is not checked or enforced by Hedera except when the chunk number is 1.
        /// </summary>
        INVALID_CHUNK_TRANSACTION_ID,

        /// <summary>
        /// Account is frozen and cannot transact with the token
        /// </summary>
        ACCOUNT_FROZEN_FOR_TOKEN,

        /// <summary>
        /// An involved account already has more than <tt>tokens.maxPerAccount</tt> associations with
        /// non-deleted tokens.
        /// </summary>
        TOKENS_PER_ACCOUNT_LIMIT_EXCEEDED,

        /// <summary>
        /// The token is invalid or does not exist
        /// </summary>
        INVALID_TOKEN_ID,

        /// <summary>
        /// Invalid token decimals
        /// </summary>
        INVALID_TOKEN_DECIMALS,

        /// <summary>
        /// Invalid token initial supply
        /// </summary>
        INVALID_TOKEN_INITIAL_SUPPLY,

        /// <summary>
        /// Treasury Account does not exist or is deleted
        /// </summary>
        INVALID_TREASURY_ACCOUNT_FOR_TOKEN,

        /// <summary>
        /// Token Symbol is not UTF-8 capitalized alphabetical string
        /// </summary>
        INVALID_TOKEN_SYMBOL,

        /// <summary>
        /// Freeze key is not set on token
        /// </summary>
        TOKEN_HAS_NO_FREEZE_KEY,

        /// <summary>
        /// Amounts in transfer list are not net zero
        /// </summary>
        TRANSFERS_NOT_ZERO_SUM_FOR_TOKEN,

        /// <summary>
        /// A token symbol was not provided
        /// </summary>
        MISSING_TOKEN_SYMBOL,

        /// <summary>
        /// The provided token symbol was too long
        /// </summary>
        TOKEN_SYMBOL_TOO_LONG,

        /// <summary>
        /// KYC must be granted and account does not have KYC granted
        /// </summary>
        ACCOUNT_KYC_NOT_GRANTED_FOR_TOKEN,

        /// <summary>
        /// KYC key is not set on token
        /// </summary>
        TOKEN_HAS_NO_KYC_KEY,

        /// <summary>
        /// Token balance is not sufficient for the transaction
        /// </summary>
        INSUFFICIENT_TOKEN_BALANCE,

        /// <summary>
        /// Token transactions cannot be executed on deleted token
        /// </summary>
        TOKEN_WAS_DELETED,

        /// <summary>
        /// Supply key is not set on token
        /// </summary>
        TOKEN_HAS_NO_SUPPLY_KEY,

        /// <summary>
        /// Wipe key is not set on token
        /// </summary>
        TOKEN_HAS_NO_WIPE_KEY,

        /// <summary>
        /// The requested token mint amount would cause an invalid total supply
        /// </summary>
        INVALID_TOKEN_MINT_AMOUNT,

        /// <summary>
        /// The requested token burn amount would cause an invalid total supply
        /// </summary>
        INVALID_TOKEN_BURN_AMOUNT,

        /// <summary>
        /// A required token-account relationship is missing
        /// </summary>
        TOKEN_NOT_ASSOCIATED_TO_ACCOUNT,

        /// <summary>
        /// The target of a wipe operation was the token treasury account
        /// </summary>
        CANNOT_WIPE_TOKEN_TREASURY_ACCOUNT,

        /// <summary>
        /// The provided KYC key was invalid.
        /// </summary>
        INVALID_KYC_KEY,

        /// <summary>
        /// The provided wipe key was invalid.
        /// </summary>
        INVALID_WIPE_KEY,

        /// <summary>
        /// The provided freeze key was invalid.
        /// </summary>
        INVALID_FREEZE_KEY,

        /// <summary>
        /// The provided supply key was invalid.
        /// </summary>
        INVALID_SUPPLY_KEY,

        /// <summary>
        /// Token Name is not provided
        /// </summary>
        MISSING_TOKEN_NAME,

        /// <summary>
        /// Token Name is too long
        /// </summary>
        TOKEN_NAME_TOO_LONG,

        /// <summary>
        /// The provided wipe amount must not be negative, zero or bigger than the token holder balance
        /// </summary>
        INVALID_WIPING_AMOUNT,

        /// <summary>
        /// Token does not have Admin key set, thus update/delete transactions cannot be performed
        /// </summary>
        TOKEN_IS_IMMUTABLE,

        /// <summary>
        /// An <tt>associateToken</tt> operation specified a token already associated to the account
        /// </summary>
        TOKEN_ALREADY_ASSOCIATED_TO_ACCOUNT,

        /// <summary>
        /// An attempted operation is invalid until all token balances for the target account are zero
        /// </summary>
        TRANSACTION_REQUIRES_ZERO_TOKEN_BALANCES,

        /// <summary>
        /// An attempted operation is invalid because the account is a treasury
        /// </summary>
        ACCOUNT_IS_TREASURY,

        /// <summary>
        /// Same TokenIDs present in the token list
        /// </summary>
        TOKEN_ID_REPEATED_IN_TOKEN_LIST,

        /// <summary>
        /// Exceeded the number of token transfers (both from and to) allowed for token transfer list
        /// </summary>
        TOKEN_TRANSFER_LIST_SIZE_LIMIT_EXCEEDED,

        /// <summary>
        /// TokenTransfersTransactionBody has no TokenTransferList
        /// </summary>
        EMPTY_TOKEN_TRANSFER_BODY,

        /// <summary>
        /// TokenTransfersTransactionBody has a TokenTransferList with no AccountAmounts
        /// </summary>
        EMPTY_TOKEN_TRANSFER_ACCOUNT_AMOUNTS,

        /// <summary>
        /// The Scheduled entity does not exist; or has now expired, been deleted, or been executed
        /// </summary>
        INVALID_SCHEDULE_ID,

        /// <summary>
        /// The Scheduled entity cannot be modified. Admin key not set
        /// </summary>
        SCHEDULE_IS_IMMUTABLE,

        /// <summary>
        /// The provided Scheduled Payer does not exist
        /// </summary>
        INVALID_SCHEDULE_PAYER_ID,

        /// <summary>
        /// The Schedule Create Transaction TransactionID account does not exist
        /// </summary>
        INVALID_SCHEDULE_ACCOUNT_ID,

        /// <summary>
        /// The provided sig map did not contain any new valid signatures from required signers of the scheduled
        /// transaction
        /// </summary>
        NO_NEW_VALID_SIGNATURES,

        /// <summary>
        /// The required signers for a scheduled transaction cannot be resolved, for example because they do not
        /// exist or have been deleted
        /// </summary>
        UNRESOLVABLE_REQUIRED_SIGNERS,

        /// <summary>
        /// Only whitelisted transaction types may be scheduled
        /// </summary>
        SCHEDULED_TRANSACTION_NOT_IN_WHITELIST,

        /// <summary>
        /// At least one of the signatures in the provided sig map did not represent a valid signature for any
        /// required signer
        /// </summary>
        SOME_SIGNATURES_WERE_INVALID,

        /// <summary>
        /// The scheduled field in the TransactionID may not be set to true
        /// </summary>
        TRANSACTION_ID_FIELD_NOT_ALLOWED,

        /// <summary>
        /// A schedule already exists with the same identifying fields of an attempted ScheduleCreate (that is,
        /// all fields other than scheduledPayerAccountID)
        /// </summary>
        IDENTICAL_SCHEDULE_ALREADY_CREATED,

        /// <summary>
        /// A string field in the transaction has a UTF-8 encoding with the prohibited zero byte
        /// </summary>
        INVALID_ZERO_BYTE_IN_STRING,

        /// <summary>
        /// A schedule being signed or deleted has already been deleted
        /// </summary>
        SCHEDULE_ALREADY_DELETED,

        /// <summary>
        /// A schedule being signed or deleted has already been executed
        /// </summary>
        SCHEDULE_ALREADY_EXECUTED,

        /// <summary>
        /// ConsensusSubmitMessage request's message size is larger than allowed.
        /// </summary>
        MESSAGE_SIZE_TOO_LARGE,

        /// <summary>
        /// An operation was assigned to more than one throttle group in a given bucket
        /// </summary>
        OPERATION_REPEATED_IN_BUCKET_GROUPS,

        /// <summary>
        /// The capacity needed to satisfy all opsPerSec groups in a bucket overflowed a signed 8-byte integral
        /// type
        /// </summary>
        BUCKET_CAPACITY_OVERFLOW,

        /// <summary>
        /// Given the network size in the address book, the node-level capacity for an operation would never be
        /// enough to accept a single request; usually means a bucket burstPeriod should be increased
        /// </summary>
        NODE_CAPACITY_NOT_SUFFICIENT_FOR_OPERATION,

        /// <summary>
        /// A bucket was defined without any throttle groups
        /// </summary>
        BUCKET_HAS_NO_THROTTLE_GROUPS,

        /// <summary>
        /// A throttle group was granted zero opsPerSec
        /// </summary>
        THROTTLE_GROUP_HAS_ZERO_OPS_PER_SEC,

        /// <summary>
        /// The throttle definitions file was updated, but some supported operations were not assigned a bucket
        /// </summary>
        SUCCESS_BUT_MISSING_EXPECTED_OPERATION,

        /// <summary>
        /// The new contents for the throttle definitions system file were not valid protobuf
        /// </summary>
        UNPARSEABLE_THROTTLE_DEFINITIONS,

        /// <summary>
        /// The new throttle definitions system file were invalid, and no more specific error could be divined
        /// </summary>
        INVALID_THROTTLE_DEFINITIONS,

        /// <summary>
        /// The transaction references an account which has passed its expiration without renewal funds
        /// available, and currently remains in the ledger only because of the grace period given to expired
        /// entities
        /// </summary>
        ACCOUNT_EXPIRED_AND_PENDING_REMOVAL,

        /// <summary>
        /// Invalid token max supply
        /// </summary>
        INVALID_TOKEN_MAX_SUPPLY,

        /// <summary>
        /// Invalid token nft serial number
        /// </summary>
        INVALID_TOKEN_NFT_SERIAL_NUMBER,

        /// <summary>
        /// Invalid nft id
        /// </summary>
        INVALID_NFT_ID,

        /// <summary>
        /// Nft metadata is too long
        /// </summary>
        METADATA_TOO_LONG,

        /// <summary>
        /// Repeated operations count exceeds the limit
        /// </summary>
        BATCH_SIZE_LIMIT_EXCEEDED,

        /// <summary>
        /// The range of data to be gathered is out of the set boundaries
        /// </summary>
        INVALID_QUERY_RANGE,

        /// <summary>
        /// A custom fractional fee set a denominator of zero
        /// </summary>
        FRACTION_DIVIDES_BY_ZERO,

        /// <summary>
        /// The transaction payer could not afford a custom fee
        /// </summary>
        INSUFFICIENT_PAYER_BALANCE_FOR_CUSTOM_FEE,

        /// <summary>
        /// More than 10 custom fees were specified
        /// </summary>
        CUSTOM_FEES_LIST_TOO_LONG,

        /// <summary>
        /// Any of the feeCollector accounts for customFees is invalid
        /// </summary>
        INVALID_CUSTOM_FEE_COLLECTOR,

        /// <summary>
        /// Any of the token Ids in customFees is invalid
        /// </summary>
        INVALID_TOKEN_ID_IN_CUSTOM_FEES,

        /// <summary>
        /// Any of the token Ids in customFees are not associated to feeCollector
        /// </summary>
        TOKEN_NOT_ASSOCIATED_TO_FEE_COLLECTOR,

        /// <summary>
        /// A token cannot have more units minted due to its configured supply ceiling
        /// </summary>
        TOKEN_MAX_SUPPLY_REACHED,

        /// <summary>
        /// The transaction attempted to move an NFT serial number from an account other than its owner
        /// </summary>
        SENDER_DOES_NOT_OWN_NFT_SERIAL_NO,

        /// <summary>
        /// A custom fee schedule entry did not specify either a fixed or fractional fee
        /// </summary>
        CUSTOM_FEE_NOT_FULLY_SPECIFIED,

        /// <summary>
        /// Only positive fees may be assessed at this time
        /// </summary>
        CUSTOM_FEE_MUST_BE_POSITIVE,

        /// <summary>
        /// Fee schedule key is not set on token
        /// </summary>
        TOKEN_HAS_NO_FEE_SCHEDULE_KEY,

        /// <summary>
        /// A fractional custom fee exceeded the range of a 64-bit signed integer
        /// </summary>
        CUSTOM_FEE_OUTSIDE_NUMERIC_RANGE,

        /// <summary>
        /// A royalty cannot exceed the total fungible value exchanged for an NFT
        /// </summary>
        ROYALTY_FRACTION_CANNOT_EXCEED_ONE,

        /// <summary>
        /// Each fractional custom fee must have its maximum\_amount, if specified, at least its minimum\_amount
        /// </summary>
        FRACTIONAL_FEE_MAX_AMOUNT_LESS_THAN_MIN_AMOUNT,

        /// <summary>
        /// A fee schedule update tried to clear the custom fees from a token whose fee schedule was already
        /// empty
        /// </summary>
        CUSTOM_SCHEDULE_ALREADY_HAS_NO_FEES,

        /// <summary>
        /// Only tokens of type FUNGIBLE\_COMMON can be used to as fee schedule denominations
        /// </summary>
        CUSTOM_FEE_DENOMINATION_MUST_BE_FUNGIBLE_COMMON,

        /// <summary>
        /// Only tokens of type FUNGIBLE\_COMMON can have fractional fees
        /// </summary>
        CUSTOM_FRACTIONAL_FEE_ONLY_ALLOWED_FOR_FUNGIBLE_COMMON,

        /// <summary>
        /// The provided custom fee schedule key was invalid
        /// </summary>
        INVALID_CUSTOM_FEE_SCHEDULE_KEY,

        /// <summary>
        /// The requested token mint metadata was invalid
        /// </summary>
        INVALID_TOKEN_MINT_METADATA,

        /// <summary>
        /// The requested token burn metadata was invalid
        /// </summary>
        INVALID_TOKEN_BURN_METADATA,

        /// <summary>
        /// The treasury for a unique token cannot be changed until it owns no NFTs
        /// </summary>
        CURRENT_TREASURY_STILL_OWNS_NFTS,

        /// <summary>
        /// An account cannot be dissociated from a unique token if it owns NFTs for the token
        /// </summary>
        ACCOUNT_STILL_OWNS_NFTS,

        /// <summary>
        /// A NFT can only be burned when owned by the unique token's treasury
        /// </summary>
        TREASURY_MUST_OWN_BURNED_NFT,

        /// <summary>
        /// An account did not own the NFT to be wiped
        /// </summary>
        ACCOUNT_DOES_NOT_OWN_WIPED_NFT,

        /// <summary>
        /// An AccountAmount token transfers list referenced a token type other than FUNGIBLE\_COMMON
        /// </summary>
        ACCOUNT_AMOUNT_TRANSFERS_ONLY_ALLOWED_FOR_FUNGIBLE_COMMON,

        /// <summary>
        /// All the NFTs allowed in the current price regime have already been minted
        /// </summary>
        MAX_NFTS_IN_PRICE_REGIME_HAVE_BEEN_MINTED,

        /// <summary>
        /// The payer account has been marked as deleted
        /// </summary>
        PAYER_ACCOUNT_DELETED,

        /// <summary>
        /// The reference chain of custom fees for a transferred token exceeded the maximum length of 2
        /// </summary>
        CUSTOM_FEE_CHARGING_EXCEEDED_MAX_RECURSION_DEPTH,

        /// <summary>
        /// More than 20 balance adjustments were to satisfy a CryptoTransfer and its implied custom fee
        /// payments
        /// </summary>
        CUSTOM_FEE_CHARGING_EXCEEDED_MAX_ACCOUNT_AMOUNTS,

        /// <summary>
        /// The sender account in the token transfer transaction could not afford a custom fee
        /// </summary>
        INSUFFICIENT_SENDER_ACCOUNT_BALANCE_FOR_CUSTOM_FEE,

        /// <summary>
        /// Currently no more than 4,294,967,295 NFTs may be minted for a given unique token type
        /// </summary>
        SERIAL_NUMBER_LIMIT_REACHED,

        /// <summary>
        /// Only tokens of type NON\_FUNGIBLE\_UNIQUE can have royalty fees
        /// </summary>
        CUSTOM_ROYALTY_FEE_ONLY_ALLOWED_FOR_NON_FUNGIBLE_UNIQUE,

        /// <summary>
        /// The account has reached the limit on the automatic associations count.
        /// </summary>
        NO_REMAINING_AUTOMATIC_ASSOCIATIONS,

        /// <summary>
        /// Already existing automatic associations are more than the new maximum automatic associations.
        /// </summary>
        EXISTING_AUTOMATIC_ASSOCIATIONS_EXCEED_GIVEN_LIMIT,

        /// <summary>
        /// Cannot set the number of automatic associations for an account more than the maximum allowed
        /// token associations <tt>tokens.maxPerAccount</tt>.
        /// </summary>
        REQUESTED_NUM_AUTOMATIC_ASSOCIATIONS_EXCEEDS_ASSOCIATION_LIMIT,

        /// <summary>
        /// Token is paused. This Token cannot be a part of any kind of Transaction until unpaused.
        /// </summary>
        TOKEN_IS_PAUSED,

        /// <summary>
        /// Pause key is not set on token
        /// </summary>
        TOKEN_HAS_NO_PAUSE_KEY,

        /// <summary>
        /// The provided pause key was invalid
        /// </summary>
        INVALID_PAUSE_KEY,

        /// <summary>
        /// The update file in a freeze transaction body must exist.
        /// </summary>
        FREEZE_UPDATE_FILE_DOES_NOT_EXIST,

        /// <summary>
        /// The hash of the update file in a freeze transaction body must match the in-memory hash.
        /// </summary>
        FREEZE_UPDATE_FILE_HASH_DOES_NOT_MATCH,

        /// <summary>
        /// A FREEZE\_UPGRADE transaction was handled with no previous update prepared.
        /// </summary>
        NO_UPGRADE_HAS_BEEN_PREPARED,

        /// <summary>
        /// A FREEZE\_ABORT transaction was handled with no scheduled freeze.
        /// </summary>
        NO_FREEZE_IS_SCHEDULED,

        /// <summary>
        /// The update file hash when handling a FREEZE\_UPGRADE transaction differs from the file
        /// hash at the time of handling the PREPARE\_UPGRADE transaction.
        /// </summary>
        UPDATE_FILE_HASH_CHANGED_SINCE_PREPARE_UPGRADE,

        /// <summary>
        /// The given freeze start time was in the (consensus) past.
        /// </summary>
        FREEZE_START_TIME_MUST_BE_FUTURE,

        /// <summary>
        /// The prepared update file cannot be updated or appended util either the upgrade has
        /// been completed, or a FREEZE\_ABORT has been handled.
        /// </summary>
        PREPARED_UPDATE_FILE_IS_IMMUTABLE,

        /// <summary>
        /// Once a freeze is scheduled, it must be aborted before any other type of freeze can
        /// can be performed.
        /// </summary>
        FREEZE_ALREADY_SCHEDULED,

        /// <summary>
        /// If an NMT upgrade has been prepared, the following operation must be a FREEZE\_UPGRADE.
        /// (To issue a FREEZE\_ONLY, submit a FREEZE\_ABORT first.)
        /// </summary>
        FREEZE_UPGRADE_IN_PROGRESS,

        /// <summary>
        /// If an NMT upgrade has been prepared, the subsequent FREEZE\_UPGRADE transaction must
        /// confirm the id of the to be used in the upgrade.
        /// </summary>
        UPDATE_FILE_ID_DOES_NOT_MATCH_PREPARED,

        /// <summary>
        /// If an NMT upgrade has been prepared, the subsequent FREEZE\_UPGRADE transaction must
        /// confirm the hash of the file to be used in the upgrade.
        /// </summary>
        UPDATE_FILE_HASH_DOES_NOT_MATCH_PREPARED,

        /// <summary>
        /// Consensus throttle did not allow execution of this transaction. System is throttled at
        /// consensus level.
        /// </summary>
        CONSENSUS_GAS_EXHAUSTED,

        /// <summary>
        /// A precompiled contract succeeded, but was later reverted.
        /// </summary>
        REVERTED_SUCCESS,

        /// <summary>
        /// All contract storage allocated to the current price regime has been consumed.
        /// </summary>
        MAX_STORAGE_IN_PRICE_REGIME_HAS_BEEN_USED,

        /// <summary>
        /// An alias used in a CryptoTransfer transaction is not the serialization of a primitive Key
        /// message--that is, a Key with a single Ed25519 or ECDSA(secp256k1) public key and no
        /// unknown protobuf fields.
        /// </summary>
        INVALID_ALIAS_KEY,

        /// <summary>
        /// An approved allowance specifies a spender account that is the same as the hbar/token
        /// owner account.
        ///
        /// </summary>
        SPENDER_ACCOUNT_SAME_AS_OWNER,

        /// <summary>
        /// The establishment or adjustment of an approved allowance cause the token allowance
        /// to exceed the token maximum supply.
        ///
        /// </summary>
        AMOUNT_EXCEEDS_TOKEN_MAX_SUPPLY,

        /// <summary>
        /// The specified amount for an approved allowance cannot be negative.
        ///
        /// </summary>
        NEGATIVE_ALLOWANCE_AMOUNT,

        /// <summary>
        /// The approveForAll flag cannot be set for a fungible token.
        ///
        /// </summary>
        CANNOT_APPROVE_FOR_ALL_FUNGIBLE_COMMON,

        /// <summary>
        /// The spender does not have an existing approved allowance with the hbar/token owner.
        ///
        /// </summary>
        SPENDER_DOES_NOT_HAVE_ALLOWANCE,

        /// <summary>
        /// The transfer amount exceeds the current approved allowance for the spender account.
        ///
        /// </summary>
        AMOUNT_EXCEEDS_ALLOWANCE,

        /// <summary>
        /// The payer account of an approveAllowances or adjustAllowance transaction is attempting to go beyond the maximum allowed number of allowances.
        /// </summary>
        MAX_ALLOWANCES_EXCEEDED,

        /// <summary>
        /// Spender is repeated more than once in Crypto or Token or NFT allowance lists in a single
        /// CryptoApproveAllowance or CryptoAdjustAllowance transaction.
        /// </summary>
        SPENDER_ACCOUNT_REPEATED_IN_ALLOWANCES,

        /// <summary>
        /// Serial numbers are repeated in nft allowance for a single spender account
        /// </summary>
        REPEATED_SERIAL_NUMS_IN_NFT_ALLOWANCES,

        /// <summary>
        /// Fungible common token used in NFT allowances
        /// </summary>
        FUNGIBLE_TOKEN_IN_NFT_ALLOWANCES,

        /// <summary>
        /// Non fungible token used in fungible token allowances
        /// </summary>
        NFT_IN_FUNGIBLE_TOKEN_ALLOWANCES,

        /// <summary>
        /// An approval/adjustment transaction was submitted where the payer and owner account are
        /// not the same. Currently only the owner is permitted to perform these operations.
        /// </summary>
        PAYER_AND_OWNER_NOT_EQUAL,

        /// <summary>
        /// A CryptoCreate or ContractCreate used the deprecated proxyAccountID field.
        /// </summary>
        PROXY_ACCOUNT_ID_FIELD_IS_DEPRECATED,

        /// <summary>
        /// An account set the staked\_account\_id to itself in CryptoUpdate or ContractUpdate transactions.
        /// </summary>
        SELF_STAKING_IS_NOT_ALLOWED,

        /// <summary>
        /// The staking account id or staking node id given is invalid or does not exist.
        /// </summary>
        INVALID_STAKING_ID,

        /// <summary>
        /// Native staking, while implemented, has not yet enabled by the council.
        /// </summary>
        STAKING_NOT_ENABLED,

        /// <summary>
        /// The range provided in UtilPrng transaction is negative.
        /// </summary>
        INVALID_PRNG_RANGE,

        /// <summary>
        /// The maximum number of entities allowed in the current price regime have been created.
        /// </summary>
        MAX_ENTITIES_IN_PRICE_REGIME_HAVE_BEEN_CREATED,

        /// <summary>
        /// The full prefix signature for precompile is not valid
        /// </summary>
        INVALID_FULL_PREFIX_SIGNATURE_FOR_PRECOMPILE,

        /// <summary>
        /// The combined balances of a contract and its auto-renew account (if any) did not cover
        /// the rent charged for net new storage used in a transaction.
        /// </summary>
        INSUFFICIENT_BALANCES_FOR_STORAGE_RENT,

        /// <summary>
        /// A contract transaction tried to use more than the allowed number of child records, via
        /// either system contract records or internal contract creations.
        /// </summary>
        MAX_CHILD_RECORDS_EXCEEDED,

        /// <summary>
        /// The combined balances of a contract and its auto-renew account (if any) or balance of an account did not cover
        /// the auto-renewal fees in a transaction.
        /// </summary>
        INSUFFICIENT_BALANCES_FOR_RENEWAL_FEES,

        /// <summary>
        /// A transaction's protobuf message includes unknown fields; could mean that a client
        /// expects not-yet-released functionality to be available.
        /// </summary>
        TRANSACTION_HAS_UNKNOWN_FIELDS,

        /// <summary>
        /// The account cannot be modified. Account's key is not set
        /// </summary>
        ACCOUNT_IS_IMMUTABLE,

        /// <summary>
        /// An alias that is assigned to an account or contract cannot be assigned to another account or contract.
        /// </summary>
        ALIAS_ALREADY_ASSIGNED,
    }
}
