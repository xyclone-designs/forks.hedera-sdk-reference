/// <summary>
/// The livehash, if present
/// The account to which the livehash is attached
/// --
/// The SHA-384 hash of a credential or certificate
/// --
/// A list of keys (primitive or threshold), all of which must sign to attach the livehash to an
/// account, and any one of which can later delete it.
/// --
/// The duration for which the livehash will remain valid
/// --
/// </summary>
public interface ILiveHash
{
}