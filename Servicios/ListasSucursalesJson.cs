using ConsoleAppAdapter.Interfaces;
using Newtonsoft.Json;

namespace ConsoleAppAdapter.Servicios
{
    public class ListasSucursalesJson : IListaSucursalesJsonAdapter
    {
        readonly IListaSucursales _listaSucursales;

        public ListasSucursalesJson(IListaSucursales listaSucursales)
        {
            _listaSucursales = listaSucursales;
        }

        public string RegresarJsonSucursales()
        {
            return JsonConvert.SerializeObject(_listaSucursales.RegresarSucursales(), Formatting.Indented);            
        }
    }
}
