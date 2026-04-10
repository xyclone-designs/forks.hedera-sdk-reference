using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference.Cryptography
{
    /// <summary>
    /// A list of Keys with an optional threshold. If a threshold is set the key list will be treated as
    /// a protobuf `ThresholdKey` type, otherwise the key list will be treated as a `KeyList` protobuf
    /// type.
    ///
    /// **KeyList**:
    /// A list of keys that requires all keys (M-of-M) to sign unless otherwise specified in
    /// documentation. A KeyList may contain repeated keys, but all repeated keys are only required to
    /// sign once.
    ///
    /// **ThresholdKey**:
    /// A set of public keys that are used together to form a threshold signature.  If the threshold is N
    /// and there are M keys, then this is an N of M threshold signature. If an account is associated
    /// with ThresholdKeys, then a transaction to move cryptocurrency out of it must be signed by a list
    /// of M signatures, where at most M-N of them are blank, and the other at least N of them are valid
    /// signatures corresponding to at least N of the public keys listed here.
    ///
    /// **Note**: This class implements the collection interface of the
    /// implementation language and thus can look very different between each SDK.
    ///
    /// **Note**: A `KeyList` can be used anywhere that a `Key` is expected in the SDK. This
    /// includes `setKey` in `AccountCreateTransaction` and `setSubmitKey` in
    /// `TopicCreateTransaction`.
    /// </summary>
    public class KeyList : List<Key>, Key
    {
        /// <summary>
        /// Construct a new `KeyList` from a list of keys
        /// </summary>
        public static KeyList Of(params Key[] keyArray);
        /// <summary>
        /// Create a new, empty list of keys with the given threshold.
        /// </summary>
        public static KeyList WithThreshold(uint threshold);

        /// <summary>
        /// Stringify the `KeyList` structure into a readable format
        /// </summary>
        string ToString();

        /// <summary>
        /// The list of keys
        /// </summary>
        IList<Key> Keys { get; }
        /// <summary>
        /// A threshold indicating that a valid signature set must have at least
        /// this many signatures.
        /// </summary>
        uint Threshold { get; }

    }
}
