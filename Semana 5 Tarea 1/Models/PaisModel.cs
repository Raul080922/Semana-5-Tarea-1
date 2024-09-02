using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using _Semana_5_Tarea_1.config;

namespace Semana_5_Tarea_1.Models
{
    class PaisModel
    {
        public int IdPais { get; set; }
        public string Detalle { get; set; }


        public DataTable todos() {
            var cadena = "select * from paises";
            using (var cn = Conexion.GetConnection())
            {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(cadena, cn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
                catch (SqlException ex)
                {
                    ErrorHandler.ManejarErrorSql(ex, "Error al insertar el autor.");
                }
                catch (Exception ex)
                {
                    ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el autor.");
                }
                return null;
            }

        }

    }
}
