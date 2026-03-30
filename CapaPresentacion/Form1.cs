
using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private readonly ICSVService servicio;

        public Form1()
        {
            InitializeComponent();
            servicio = new CSVService();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog
            {
                Filter = "CSV (*.csv)|*.csv"
            };

            if (of.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var data = servicio.ObtenerDatos(of.FileName);

                if (data.Rows.Count == 0)
                {
                    MessageBox.Show("El archivo está vacío");
                    return;
                }

                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
