using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semana_5_Tarea_1.Views.Empleados;
using Semana_5_Tarea_1.Views.Autores;


namespace Semana_5_Tarea_1.Views
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_empleados _Empleados = new frm_empleados();
            _Empleados.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Autores _Autores = new frm_Autores();
            _Autores.ShowDialog();

        }

        private void trabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
