using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semana_5_Tarea_1.config;
using Semana_5_Tarea_1.Controllers;
namespace Semana_5_Tarea_1.Views.Ciudades
{
    public partial class frm_Lista_Ciudades : Form
    {
        CiudadesController _ciudadesController = new CiudadesController();
        public frm_Lista_Ciudades()
        {
            InitializeComponent();
        }

        private void frm_Lista_Ciudades_Load(object sender, EventArgs e)
        {

            dgvCiudades.DataSource = _ciudadesController.todosconrelacion();


            dgvCiudades.Columns[0].Visible = false;
            dgvCiudades.Columns[1].Visible = true;
            dgvCiudades.Columns[2].Visible = false;
            dgvCiudades.Columns[3].Visible = true;

            DataGridViewButtonColumn btnGrid = new DataGridViewButtonColumn();
            btnGrid.HeaderText = "Editar";
            btnGrid.Name = "Editar";
            btnGrid.Text = "Editar";
            btnGrid.UseColumnTextForButtonValue = true;
            dgvCiudades.Columns.Add(btnGrid);




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            MessageBox.Show(id);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCiudades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCiudades.Columns["Editar"].Index && e.RowIndex >= 0) {
                var id = dgvCiudades.Rows[e.RowIndex].Cells["IdCiudad"].Value.ToString();
                frm_Ciudades _Ciudades = new frm_Ciudades(id);
                _Ciudades.Show();
            }
        }
    }
}
