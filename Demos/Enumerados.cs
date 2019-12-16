using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos {
    public enum DiasLaborables : byte {
        lunes = 10, martes, miercoles, jueves, viernes
    }
    public enum Dias : byte {
        lunes = 10, martes, miercoles, jueves, viernes, sabado, domingo
    }

    public class Nomina {
        public enum DiasLaborables : byte {
            lunes = 10, martes, miercoles, jueves, viernes
        }

        public DiasLaborables dias() {
            return DiasLaborables.jueves;
        }
    }
}
