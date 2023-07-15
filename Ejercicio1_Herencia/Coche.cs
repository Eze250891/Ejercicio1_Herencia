using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Herencia
{
    public class Coche : Vehiculo
    {
        public int CantidadPuertas { get; set; }

        public string LimpiarParabrisas()
        {
            return $"Limpiando el parabrisas";
        }
    }
}
