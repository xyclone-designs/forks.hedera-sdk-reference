/// <summary>
/// &gt; class `TokenId`
/// &lt;details&gt;
/// &lt;summary&gt;&lt;b&gt;Table of Contents&lt;/b&gt;&lt;/summary&gt;
/// | Item | Java | JavaScript | Go
/// | - | - | - | - |
/// | [`constructor`](#constructor-num-uint64-) | ✅ | ✅ | ✅
/// | [`fromString`](#fromstring-str-string-tokenid) | ✅ | ✅ | ✅
/// | [`fromBytes`](#frombytes-data-bytes-tokenid) | ✅ | ✅ | ✅
/// | [`shard`](#shard-uint64) | ✅ | ✅ | ✅
/// | [`realm`](#realm-uint64) | ✅ | ✅ | ✅
/// | [`num`](#num-uint64) | ✅ | ✅ | ✅
/// | [`toBytes`](#tobytes-bytes) | ✅ | ✅ | ✅
/// &lt;/details&gt;
/// An ID type that represents a token on a Hedera Hashgraph network.
/// Construct a [`TokenId`](#) with [`shard`](#shard-uint64) and [`realm`](#realm-uint64) being zero.
/// --
/// Construct a [`TokenId`](#) with all fields explicitly set.
/// --
/// Construct a [`TokenId`](#) from a string. The format of the string could be either just
/// a number "4" or dot separated numbers "0.0.4".
/// Deserialize a [`TokenId`](#) from its the protobuf representation.
/// Serialize the [`TokenId`](#) into its protobuf representation.
/// --
/// The shard of this ID.
/// --
/// The realm of this ID.
/// --
/// The num of this ID.
/// --
/// </summary>
public interface ITokenId
{
}