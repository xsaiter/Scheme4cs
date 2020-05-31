using System;
using System.Diagnostics.CodeAnalysis;

namespace Scheme4cs {
    public class Cell : IEquatable<Cell> {
        public object First { get; set; }
        public object Rest { get; set; }

        public Cell(object first, object rest) => (First, Rest) = (first, rest);

        public bool Equals([AllowNull] Cell other) {
            if (other == null) {
                return false;
            }
            if (ReferenceEquals(other, this)) {
                return true;
            }
            return First.Equals(other.First) && Rest.Equals(other.Rest);
        }

        public override bool Equals(object obj) {
            return Equals(obj as Cell);
        }

        public override int GetHashCode() {            
            return HashCode.Combine(First, Rest);
        }       
    }
}
