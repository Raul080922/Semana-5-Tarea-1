using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Semana_5_Tarea_1.config;

namespace Semana_5_Tarea_1.Controllers
{
    public class AutorController
    {

        public Autor InsertarAutor(Autor autor)
        {
             return Autor.Insertar(autor);
        }

        public string ActualizarAutor(Autor autor)
        {
               return Autor.Actualizar(autor);               
        }
        public string EliminarAutor(string idAutor)
        {
                return Autor.Eliminar(idAutor);
        }
        public Autor ObtenerAutorPorId(string idAutor)
        {
                return Autor.ObtenerPorId(idAutor);
        }
        public List<Autor> ObtenerTodosLosAutores()
        {
                return Autor.ObtenerTodos();
        }
    }
}
