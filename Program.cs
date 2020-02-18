using ConsoleAppAdapter.Interfaces;
using ConsoleAppAdapter.Servicios;
using System;

namespace ConsoleAppAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IListaSucursales sucursales = new ListaSucursales();
            IListaSucursalesJsonAdapter adapter = new ListasSucursalesJson(sucursales);
            

            Console.WriteLine("\nImprimiendo el JSON mediante el adapter que lee la lista de entidades de la otra clase: \n");

            Console.WriteLine(adapter.RegresarJsonSucursales());
        }
    }
}
