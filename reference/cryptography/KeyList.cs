/// <summary>
/// &gt; class `KeyList` extends `Collection&lt;Key&gt;` implements [`Key`](Key.md)
/// A list of Keys with an optional threshold. If a threshold is set the key list will be treated as
/// a protobuf `ThresholdKey` type, otherwise the key list will be treated as a `KeyList` protobuf
/// type.
/// **KeyList**:
/// A list of keys that requires all keys (M-of-M) to sign unless otherwise specified in
/// documentation. A KeyList may contain repeated keys, but all repeated keys are only required to
/// sign once.
/// **ThresholdKey**:
/// A set of public keys that are used together to form a threshold signature.  If the threshold is N
/// and there are M keys, then this is an N of M threshold signature. If an account is associated
/// with ThresholdKeys, then a transaction to move cryptocurrency out of it must be signed by a list
/// of M signatures, where at most M-N of them are blank, and the other at least N of them are valid
/// signatures corresponding to at least N of the public keys listed here.
/// **Note**: This class implements the collection interface of the
/// implementation language and thus can look very different between each SDK.
/// **Note**: A `KeyList` can be used anywhere that a `Key` is expected in the SDK. This
/// includes `setKey` in `AccountCreateTransaction` and `setSubmitKey` in
/// `TopicCreateTransaction`.
/// &lt;!-- tabs:start --&gt;
/// ```java
/// // imperative
/// var keyList = KeyList.withThreshold(1);
/// keyList.add(keyA);
/// keyList.add(keyB);
/// // fluid
/// var keyList = KeyList.of(keyA, keyB).setThreshold(1);
/// ```
/// ```javascript
/// // imperative
/// const keyList = KeyList.withThreshold(1);
/// keyList.add(key1);
/// keyList.addAll(List.of(key2, key3));
/// // fluid
/// const keyList = KeyList.of(keyA, keyB).setThreshold(1);
/// ```
/// ```go
/// // imperative
/// keyList := NewKeyList()
/// keyList = keyList.SetThreshold(1)
/// keyList = keyList.Append(keyA)
/// keyList = keyList.Append(keyB)
/// // from array
/// keyList := NewKeyListFromSlice([]{
/// keyA,
/// keyB,
/// }).SetThreshold(1)
/// // fluid
/// keyList := NewKeyListWith(keyA, keyB).SetThreshold(1)
/// ```
/// &lt;!-- tabs:end --&gt;
/// Create a new, empty list of keys with no threshold.
/// Construct a new `KeyList` from a list of keys
/// --
/// Create a new, empty list of keys with the given threshold.
/// --
/// Stringify the `KeyList` structure into a readable format
/// --
/// The list of keys
/// --
/// A threshold indicating that a valid signature set must have at least
/// this many signatures.
/// </summary>
public interface IKeyList
{
    /// <summary>
    /// --
    /// </summary>
    --;

}