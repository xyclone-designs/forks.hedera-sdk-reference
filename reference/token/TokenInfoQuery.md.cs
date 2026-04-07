namespace Hedera.Hashgraph.Reference.Token
{
    /// <summary>
    /// <details>
    /// <summary><b>Declaration</b></summary>
    ///
    /// ```typescript
    /// class TokenInfoQuery extends Query<TokenInfo> {
    /// constructor();
    ///
    /// /* property */ TokenId: TokenId;
    /// }
    /// ```
    ///
    /// </details>
    ///
    /// </summary>
    public interface ITokenInfoQuery
    {
        /// <summary>
        ///
        /// </summary>
        ITokenId TokenId { get; }

    }
}
