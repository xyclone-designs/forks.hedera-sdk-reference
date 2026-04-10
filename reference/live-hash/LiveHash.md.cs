using Hedera.Hashgraph.Reference.Core;
using Hedera.Hashgraph.Reference.Cryptocurrency;
using Hedera.Hashgraph.Reference.Cryptography;

using System;

namespace Hedera.Hashgraph.Reference.LiveHash
{
    public interface ILiveHash 
    {
        /// <summary>
        /// The account to which the livehash is attached
        /// </summary>
        AccountId AccountId { get; }
        /// <summary>
        /// The SHA-384 hash of a credential or certificate
        /// </summary>
        byte[] Hash { get; }
        /// <summary>
        /// A list of keys (primitive or threshold), all of which must sign to attach the livehash to an
        /// account, and any one of which can later delete it.
        /// </summary>
        KeyList Keys { get; }
        /// <summary>
        /// The duration for which the livehash will remain valid
        /// </summary>
        TimeSpan TimeSpan { get; }
    }
}
