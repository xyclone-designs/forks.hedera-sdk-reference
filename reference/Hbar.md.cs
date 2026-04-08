using System.Numerics;

namespace Hedera.Hashgraph.Reference
{
    public interface IHbar
    {
        /// <summary>
        /// A constant value of zero hbars.
        /// </summary>
        abstract static IHbar ZERO { get; }
        /// <summary>
        /// A constant value of the maximum number of hbars.
        /// </summary>
        abstract static IHbar MAX { get; }
        /// <summary>
        /// A constant value of the minimum number of hbars.
        /// </summary>
        abstract static IHbar MIN { get; }

        abstract static IHbar Construct(long amount);
        abstract static IHbar Construct(BigDecimal amount);

        abstract static IHbar From(long hbars);
        abstract static IHbar From(long amount, HbarUnit unit);
        abstract static IHbar From(BigDecimal hbras);
        abstract static IHbar From(BigDecimal amount, HbarUnit unit);
        abstract static IHbar FromString(string text);
        abstract static IHbar FromString(string text, HbarUnit unit);
        abstract static IHbar FromTinybars(long tinybars);

        BigDecimal GetValue();
        BigDecimal To(HbarUnit unit);
        long ToTinybars();

        IHbar Negated();
        bool Equals(object? obj);
        bool CompareTo(IHbar? hbar);
    }
}
