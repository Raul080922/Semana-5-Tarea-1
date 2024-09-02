using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semana_5_Tarea_1.Models;
using System.Data;
namespace Semana_5_Tarea_1.Controllers
{
    class PaisesController
    {
        PaisModel _PaisModel = new PaisModel();

        public DataTable todos() {

            return _PaisModel.todos();
        
        
        }

            }
}
