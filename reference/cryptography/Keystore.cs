
namespace Hedera.Hashgraph.Reference.Cryptography
{
    public interface IKeystore 
    {
        // NOTE: .md file not found in repository. Interface created for build success and nothing more
    }
    public interface IKeystore<TSelf> : IKeystore, IPublicKey<TSelf> where TSelf : IKeystore<TSelf> { }
}
