
using ConsoleAppAdapter.Entidades;
using ConsoleAppAdapter.Interfaces;
using System.Collections.Generic;

namespace ConsoleAppAdapter.Servicios
{
    public class ListaSucursales : IListaSucursales
    {
        public List<Sucursal> RegresarSucursales()
        {
            return SucursalesDataProvider.GetSucursales;
        }
    }
}
