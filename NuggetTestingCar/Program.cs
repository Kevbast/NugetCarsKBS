// See https://aka.ms/new-console-template for more information

using NugetCarsKBS;

Console.WriteLine("Mis coches de nugget");

Garaje g = new Garaje();
List<Coche> cochecitos = g.GetCoches();

foreach (Coche coche in cochecitos)
{
    Console.WriteLine(coche.Marca+" "+ coche.Modelo);
}