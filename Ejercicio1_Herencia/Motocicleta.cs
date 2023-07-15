using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Herencia
{
    public class Motocicleta : Vehiculo
    {
        public int CantidadPatas {get; set;}

        public string DejarlaQuieta()
        {
            return $"La moto se quedo quieta con {CantidadPatas} pata";
        }
    }
}
