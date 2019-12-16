using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curso.datos;
using otro.espacio;

namespace Demos {
    class Program: IDisposable {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            Calculadora c = new CalculadoraCientifica();
            double d = 4;

            Console.WriteLine(c.add(2));
            Console.WriteLine(c.add(2));
            Console.WriteLine(c.add(1,3));
            Console.WriteLine(c.minus(ref d, init: 12));
            Console.WriteLine(c.Resultado);
            //c.Resultado = 4;
            Console.ReadLine();
        }
        #region Metodos
        /// <summary>
        /// Método de ejemplo
        /// 
        /// </summary>
        /// <param name="parámetro">Es el parametro</param>
        /// <returns>un valor</returns>
        /// <exception cref="InvalidOperationException">Porque</exception>
        public static string metodo(int parámetro) {
            var d = Nomina.DiasLaborables.jueves;
            var c = 'd';
            kk k;
            //d = Enum.GetValues(;
 /*           int? i;
            Nullable<int> j;

            dynamic s = (new Program());
            s = 4.ToString();
            try {
                s.algo();
            } catch (Exception e) {
                
                throw new Exception("Algo", e);
            }

 #region Depuración
            #if DEBUG
            Console.WriteLine("Esto es una demo");
#endif
 #endregion
*/            return "Algo";
        }

        public void Dispose() {
            throw new NotImplementedException();
        }
        #endregion
    }
}
