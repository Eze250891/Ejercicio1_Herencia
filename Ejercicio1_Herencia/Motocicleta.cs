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
            if (CantidadPatas == 1)
            {
                return $"La moto se quedo quieta con una pata";
            }
            if (CantidadPatas > 1)
            {
                return $"La moto se quedo quieta con {CantidadPatas} patas";
            }
            return $"ERROR AL INGRESAR LA CANTIDAD DE PATAS";
        }
    }
}
