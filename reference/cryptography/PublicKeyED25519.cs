
namespace Hedera.Hashgraph.Reference.Cryptography
{
    public interface IPublicKeyED25519 : IPublicKey
    {
        // NOTE: .md file not found in repository. Interface created for build success and nothing more
    }
    public interface IPublicKeyED25519<TSelf> : IPublicKeyED25519, IPublicKey<TSelf> where TSelf : IPublicKeyED25519<TSelf> { }
}
