
using System.Data;
using System.IO;

namespace CapaDatos
{
    public class DatosCSV
    {
        public DataTable LeerCSV(string ruta)
        {
            var dt = new DataTable();

            using (var sr = new StreamReader(ruta))
            {
                var linea = sr.ReadLine();

                if (string.IsNullOrWhiteSpace(linea))
                    return dt;

                var headers = linea.Split(',');

                foreach (var h in headers)
                    dt.Columns.Add(h.Trim());

                string fila;

                while ((fila = sr.ReadLine()) != null)
                {
                    dt.Rows.Add(fila.Split(','));
                }
            }

            return dt;
        }
    }
}
