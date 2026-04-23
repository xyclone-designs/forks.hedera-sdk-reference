
namespace Hedera.Hashgraph.Reference.Cryptography
{
    public interface IPrivateKeyECDSA : IPrivateKey
    {
        // NOTE: .md file not found in repository. Interface created for build success and nothing more
    }
    public interface IPrivateKeyECDSA<TSelf> : IPrivateKeyECDSA, IPrivateKey<TSelf> where TSelf : IPrivateKeyECDSA<TSelf> { }
}
