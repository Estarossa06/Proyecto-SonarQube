
namespace CapaPresentacion
{
    partial class Form1
    {
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCargar;

        private void InitializeComponent()
        {
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnCargar = new System.Windows.Forms.Button();

            dataGridView1.Location = new System.Drawing.Point(30, 60);
            dataGridView1.Size = new System.Drawing.Size(500, 250);

            btnCargar.Text = "Cargar CSV";
            btnCargar.Location = new System.Drawing.Point(30, 20);
            btnCargar.Click += btnCargar_Click;

            Controls.Add(dataGridView1);
            Controls.Add(btnCargar);

            Text = "Clean CSV Architecture";
        }
    }
}
