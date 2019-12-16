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
 #region Depuración
            #if DEBUG
            Console.WriteLine("Esto es una demo");
#endif
 #endregion
            return "Algo";
        }

        public void Dispose() {
            throw new NotImplementedException();
        }
        #endregion
    }
}
