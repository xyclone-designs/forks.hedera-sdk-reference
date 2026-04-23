
namespace Hedera.Hashgraph.Reference.Cryptography
{
    public interface IPrivateKeyED25519 : IPrivateKey
    {
        // NOTE: .md file not found in repository. Interface created for build success and nothing more
    }
    public interface IPrivateKeyED25519<TSelf> : IPrivateKeyED25519, IPrivateKey<TSelf> where TSelf : IPrivateKeyED25519<TSelf> { }
}
