using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Validaciones {
    public static class Validaciones {
        public static bool EstaVacia(this string cad) {
            return string.IsNullOrWhiteSpace(cad);
        }
        public static bool NoEstaVacia(this string cad) {
            return !EstaVacia(cad);
        }
        public static bool MaxLen(this string cad, int len) {
            return cad.NoEstaVacia() && cad.Length <= len;
        }
        public static bool Positivo(this double num) {
            return num >= 0;
        }
    }
}
