using System;

namespace Hedera.Hashgraph.Reference.Token
{
    public class TokenRelationship
    {
        public TokenRelationship(TokenId tokenId, string symbol, long balance, bool kycStatus, bool freezeStatus)
        {
            TokenId = tokenId;
            Symbol = symbol;
            Balance = balance;
            KycStatus = kycStatus;
            FreezeStatus = freezeStatus;
        }

        public static TokenRelationship FromBytes(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public virtual byte[] ToBytes()
        {
            throw new NotImplementedException();
        }

        public TokenId TokenId { get; }
        public string Symbol { get; }
        public long Balance { get; }
        public bool KycStatus { get; }
        public bool FreezeStatus { get; }
    }
}
