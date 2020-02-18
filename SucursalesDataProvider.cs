using ConsoleAppAdapter.Entidades;
using System.Collections.Generic;

namespace ConsoleAppAdapter
{
    public static class SucursalesDataProvider
    {
        public static List<Sucursal> GetSucursales => new List<Sucursal>
        {
            new Sucursal(){Id = "1", Nombre = "Nombre 1", TotalVentasDia = 12545.56 },
            new Sucursal(){Id = "2", Nombre = "Nombre 2", TotalVentasDia = 21545.56 },
            new Sucursal(){Id = "3", Nombre = "Nombre 3", TotalVentasDia = 34545.56 },
            new Sucursal(){Id = "4", Nombre = "Nombre 4", TotalVentasDia = 56545.56 },
            new Sucursal(){Id = "5", Nombre = "Nombre 5", TotalVentasDia = 98545.56 }
        };
           
    }
}
