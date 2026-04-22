using System.Numerics;

namespace Hedera.Hashgraph.Reference
{
    public interface IHbar
    {
        long ToTinybars();
        BigDecimal To(HbarUnit unit);
        BigDecimal GetValue();

        string ToString(HbarUnit unit);
    }
    public interface IHbar<TSelf> : IHbar where TSelf : class, IHbar<TSelf>
    {
        abstract static TSelf FromString(string text);
        abstract static TSelf FromString(string text, HbarUnit unit);
        abstract static TSelf From(long hbars);
        abstract static TSelf From(long amount, HbarUnit unit);
        abstract static TSelf From(BigDecimal hbars);
        abstract static TSelf From(BigDecimal amount, HbarUnit unit);
        abstract static TSelf FromTinybars(long tinybars);
        abstract static TSelf FromTinybars(ulong tinybars);

        TSelf Negated();
        int CompareTo(TSelf? o);
    }
}
