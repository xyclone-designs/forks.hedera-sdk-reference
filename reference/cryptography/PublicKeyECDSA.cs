
namespace Hedera.Hashgraph.Reference.Cryptography
{
    public interface IPublicKeyECDSA : IPublicKey
    {
        // NOTE: .md file not found in repository. Interface created for build success and nothing more
    }
    public interface IPublicKeyECDSA<TSelf> : IPublicKeyECDSA, IPublicKey<TSelf> where TSelf : IPublicKeyECDSA<TSelf> { }
}
