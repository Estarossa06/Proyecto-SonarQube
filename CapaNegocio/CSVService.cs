
using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CSVService : ICSVService
    {
        private readonly DatosCSV datos;

        public CSVService()
        {
            datos = new DatosCSV();
        }

        public DataTable ObtenerDatos(string ruta)
        {
            if (string.IsNullOrWhiteSpace(ruta))
                throw new ArgumentException("Ruta inválida");

            try
            {
                return datos.LeerCSV(ruta);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer el archivo CSV", ex);
            }
        }
    }
}
