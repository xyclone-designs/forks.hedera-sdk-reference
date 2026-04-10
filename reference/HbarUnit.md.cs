using System;
using System.Collections.Generic;

namespace Hedera.Hashgraph.Reference
{
    public readonly struct HbarUnit : Comparable<HbarUnit>, IEquatable<HbarUnit>
    {
        public const string TINYBAR_NAME = "TINYBAR";
        public const string MICROBAR_NAME = "MICROBAR";
        public const string MILLIBAR_NAME = "MILLIBAR";
        public const string HBAR_NAME = "HBAR";
        public const string KILOBAR_NAME = "KILOBAR";
        public const string MEGABAR_NAME = "MEGABAR";
        public const string GIGABAR_NAME = "GIGABAR";

        public const string TINYBAR_SYMBOL = "tℏ";
        public const string MICROBAR_SYMBOL = "μℏ";
        public const string MILLIBAR_SYMBOL = "mℏ";
        public const string HBAR_SYMBOL = "ℏ";
        public const string KILOBAR_SYMBOL = "kℏ";
        public const string MEGABAR_SYMBOL = "Mℏ";
        public const string GIGABAR_SYMBOL = "Gℏ";


        /// <summary>
        /// The atomic (smallest) unit of hbar, used natively by the Hedera network.
        /// It is equivalent to <sup>1</sup>&frasl;<sub>100,000,000</sub> hbar.
        /// </summary>
        public static readonly HbarUnit TINYBAR = new(TINYBAR_NAME, TINYBAR_SYMBOL, 1L);
        /// <summary>
        /// Equivalent to 100 tinybar or <sup>1</sup>&frasl;<sub>1,000,000</sub> hbar.
        /// </summary>
        public static readonly HbarUnit MICROBAR = new(MICROBAR_NAME, MICROBAR_SYMBOL, 100L);
        /// <summary>
        /// Equivalent to 100,000 tinybar or <sup>1</sup>&frasl;<sub>1,000</sub> hbar.
        /// </summary>
        public static readonly HbarUnit MILLIBAR = new(MILLIBAR_NAME, MILLIBAR_SYMBOL, 100_000L);
        /// <summary>
        /// The base unit of hbar, equivalent to 100 million tinybar.
        /// </summary>
        public static readonly HbarUnit HBAR = new(HBAR_NAME, HBAR_SYMBOL, 100_000_000L);
        /// <summary>
        /// Equivalent to 1 thousand hbar or 100 billion tinybar.
        /// </summary>
        public static readonly HbarUnit KILOBAR = new(KILOBAR_NAME, KILOBAR_SYMBOL, 1000 * 100_000_000L);
        /// <summary>
        /// Equivalent to 1 million hbar or 100 trillion tinybar.
        /// </summary>
        public static readonly HbarUnit MEGABAR = new(MEGABAR_NAME, MEGABAR_SYMBOL, 1_000_000 * 100_000_000L);
        /// <summary>
        /// Equivalent to 1 billion hbar or 100 quadillion tinybar.
        /// </summary>
        public static readonly HbarUnit GIGABAR = new(GIGABAR_NAME, GIGABAR_SYMBOL, 1_000_000_000 * 100_000_000L);

        public static IEnumerable<HbarUnit> Values()
        {
            yield return TINYBAR;
            yield return MICROBAR;
            yield return MILLIBAR;
            yield return HBAR;
            yield return KILOBAR;
            yield return MEGABAR;
            yield return GIGABAR;
        }

        // Private constructor ensures only the predefined units can be created
        private HbarUnit(string name, string symbol, long tinybar)
        {
            Name = name;
            Symbol = symbol;
            Tinybar = tinybar;
        }

        public string Name { get; }
        public string Symbol { get; }
        public long Tinybar { get; }

        public bool Equals(HbarUnit other)
        {
            throw new NotImplementedException();
        }
        public int CompareTo(HbarUnit other)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Symbol, Tinybar);
        }
        public override string ToString()
        {
            return Name.ToLowerInvariant();
        }
        public override bool Equals(object? obj)
        {
            return obj is HbarUnit hbarunit && Equals(hbarunit);
        }

        public static bool operator ==(HbarUnit left, HbarUnit right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(HbarUnit left, HbarUnit right)
        {
            return !(left == right);
        }
        public static bool operator <(HbarUnit left, HbarUnit right)
        {
            return left.CompareTo(right) < 0;
        }
        public static bool operator <=(HbarUnit left, HbarUnit right)
        {
            return left.CompareTo(right) <= 0;
        }
        public static bool operator >(HbarUnit left, HbarUnit right)
        {
            return left.CompareTo(right) > 0;
        }
        public static bool operator >=(HbarUnit left, HbarUnit right)
        {
            return left.CompareTo(right) >= 0;
        }
    }
}
