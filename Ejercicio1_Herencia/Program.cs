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

            Console.WriteLine(coche.Marca);
            Console.WriteLine(coche.Modelo);
            Console.WriteLine(coche.CantidadPuertas);
            Console.WriteLine(arrancarAuto);
            Console.WriteLine(limpiarParabrisa);

            Console.WriteLine("---------------------------------------");

            var moto = new Motocicleta()
            {
                Marca = "Gilera",
                Modelo = "Al Corte",
                CantidadPatas = 1,
            };

            var arrancarMoto = moto.ArrancarMotor();
            var dejarlaquieta = moto.DejarlaQuieta();

            Console.WriteLine(moto.Marca);
            Console.WriteLine(moto.Modelo);
            Console.WriteLine(moto.CantidadPatas);
            Console.WriteLine(arrancarMoto);
            Console.WriteLine(dejarlaquieta);
        }
    }
}