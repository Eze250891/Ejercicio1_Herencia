using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Herencia
{
    public abstract class Vehiculo //en este caso siendo abastracto, te evitas crear un vehiculo.
    {
        public string Marca { get; set; }

        public string Modelo { get; set;}

        public string ArrancarMotor() 
        {
            return "Se encendio el motor";
        }
    }
}
