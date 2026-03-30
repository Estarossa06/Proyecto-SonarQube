
using System.Data;

namespace CapaNegocio
{
    public interface ICSVService
    {
        DataTable ObtenerDatos(string ruta);
    }
}
