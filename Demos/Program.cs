using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos {
    class Program: IDisposable {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            Program.metodo(4);
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
