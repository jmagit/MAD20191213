using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos {
    public partial class CalculadoraCientifica {
        public double product(ref double operando) {
            Resultado *= operando;
            return Resultado;
        }

        partial void cotilla(string msg) {
            Console.WriteLine("El metodo parcial.");
        }
    }
}
