using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Demos {
    public struct Posicion {
        int fila, columna;

        public int Fila { get => fila; set => fila = (0 < value && value <= 8) ? value : throw new JuegoException("Fuera del tablero") ; }
        public int Columna { get => columna; set => columna = (0 < value && value <= 8) ? value : throw new JuegoException("Fuera del tablero"); }

    }

    public struct Movimiento {
        public Posicion Inicial { get; set; }
        public Posicion Final { get; set; }

        public bool EsValida() {
            return !Inicial.Equals(Final);
        }
    }
    public class JuegoException: Exception {
        public JuegoException(): this("Error en el juego") { }

        public JuegoException(string message) : base(message) {
        }

        public JuegoException(string message, Exception innerException) : base(message, innerException) {
        }

        protected JuegoException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
    public enum Color { Blanco, Negro }

    public abstract class Pieza { 
        public Color Color { get; }

        public Pieza(Color color) {
            Color = color;
        }

        public virtual bool EsValido(Tablero t, Movimiento m) {
            if (t[m.Inicial.Fila, m.Inicial.Columna] != this)
                return false;
            if (t[m.Final.Fila, m.Final.Columna] != null 
                    && t[m.Final.Fila, m.Final.Columna].Color == Color)
                return false;
            return true;
        }
        public void Muevete(Tablero t, Movimiento m) {
            if(EsValido(t, m)) {
                t[m.Inicial.Fila, m.Inicial.Columna] = null;
                t[m.Final.Fila, m.Final.Columna] = this;
            } else {
                throw new JuegoException("Movimiento invalido");
            }
        }
    }
    public class Rey : Pieza {
        public Rey(Color color): base(color) { }
        public override bool EsValido(Tablero t, Movimiento m) {
            if (Math.Abs(m.Inicial.Fila - m.Final.Fila) > 1 ||
                Math.Abs(m.Inicial.Columna - m.Final.Columna) > 1)
                return false;
            return base.EsValido(t, m);
        }
    }
    public class Reina : Pieza {
        public Reina(Color color) : base(color) { }
    }
    public class Peon : Pieza {
        public class PromocionEvenArg: EventArgs {
            public Pieza Pieza { get; set; }
        }
        public event Action<Object, PromocionEvenArg> Promocion;

        protected void OnPromocion(PromocionEvenArg e) {
            if (Promocion != null)
                Promocion(this, e);
        }
        public Peon(Color color) : base(color) { }
        public new void Muevete(Tablero t, Movimiento m) {
            if (EsValido(t, m)) {
                if(m.Final.Fila == 1 || m.Final.Fila == 8) {
                    var e = new PromocionEvenArg();
                    OnPromocion(e);
                    if(e.Pieza == null)
                        throw new JuegoException("Falta la pieza");
                    // ...
                }
            }
            base.Muevete(t, m);
        }
    }
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
        public void init() {
            t.ponPieza(1, 1, new Rey(Color.Blanco));
            t[1, 1] = new Rey(Color.Blanco);
            var p = new Peon(Color.Negro);
            p.Promocion += P_Promocion;
        }

        private void P_Promocion(object sender, Peon.PromocionEvenArg e) {
            e.Pieza = new Reina(Color.Negro);
        }
    }
}
