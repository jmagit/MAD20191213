using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos {
    public class Pieza { }
    public class Rey : Pieza { }

    public class Tablero {
        private Pieza[,] tablero = new Pieza[8, 8];

        public void ponPieza(int fila, int col, Pieza p) {
            tablero[fila - 1, col - 1] = p;
        }

        public Pieza this[int fila, int col] {
            get {
                return tablero[fila - 1, col - 1];
            }
            set {
                tablero[fila - 1, col - 1] = value;
            }
        }
    }
    class Ajedrez {
        Tablero t;
        public void inti() {
            t.ponPieza(1, 1, new Rey());
            t[1, 1] = new Rey();
        }
    }
}
