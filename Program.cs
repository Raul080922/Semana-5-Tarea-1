using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semana_5_Tarea_1.Views.Ciudades;
namespace Semana_5_Tarea_1
{
    
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Lista_Ciudades());
        }
    }
}
