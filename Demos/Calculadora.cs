using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos {
    public interface ICalculadora {
        double add(double operando);
        double add(params double[] operandos);

        string Nombre { get; set; }
    }
#pragma warning disable CS1591 // Falta el comentario XML para el tipo o miembro visible públicamente
    public abstract class Calculadora : ICalculadora {
        private double resultado = 0;

        public double Resultado {
            get { return resultado; }
            protected set {
                if(resultado != value && value > 0) 
                    resultado = value; 
            }
        }

        public string Nombre { get; set; } = "Calculadora";

        public virtual double add(double operando) {
            Resultado += operando;
            return Resultado;
        }
        public double add(params double[] operandos) {
            foreach (var d in operandos)
                Resultado += d;
            return Resultado;
        }

        public abstract double minus(ref double operando, double init = 0);
    }

    public partial class CalculadoraCientifica : Calculadora, IDisposable {
        public override double add(double operando) {
            return base.add(operando);
        }
        public void Dispose() {
            //throw new NotImplementedException();
        }

        public override double minus(ref double operando, double init = 0) {
            Resultado -= operando;
            operando = init;
            cotilla("Minis");
            return Resultado;
        }

        partial void cotilla(string msg);
    }
}
