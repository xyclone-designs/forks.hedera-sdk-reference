
namespace Hedera.Hashgraph.Reference.Fees
{
    public interface INetworkFee
    {
        // NOTE: .md file not found in repository. Interface created for build success and nothing more
    }
    public interface INetworkFee<TSelf> : INetworkFee where TSelf : INetworkFee<TSelf> { }
}
