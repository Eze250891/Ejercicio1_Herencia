namespace Ejercicio1_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coche = new Coche()
            {
                Marca = "Alfa Romeo",
                Modelo = "Julia",
                CantidadPuertas = 2,
            };

            var arrancarAuto = coche.ArrancarMotor();
            var limpiarParabrisa = coche.LimpiarParabrisas();

            Console.WriteLine($"El coche es de marca {coche.Marca}");
            Console.WriteLine($"Es de marca {coche.Modelo}");
            Console.WriteLine($"Tiene {coche.CantidadPuertas} puertas");
            Console.WriteLine(arrancarAuto);
            Console.WriteLine(limpiarParabrisa);

            Console.WriteLine("---------------------------------------");

            var moto = new Motocicleta()
            {
                Marca = "Gilera",
                Modelo = "Al Corte",
                CantidadPatas = 0,
            };

            var arrancarMoto = moto.ArrancarMotor();
            var dejarlaQuieta = moto.DejarlaQuieta();

            Console.WriteLine($"La moto es de marca {moto.Marca}");
            Console.WriteLine($"El modelo es {moto.Modelo}");
            Console.WriteLine($"Y la cantidad de patas es de {moto.CantidadPatas}");
            Console.WriteLine(arrancarMoto);
            Console.WriteLine(dejarlaQuieta);
        }
    }
}