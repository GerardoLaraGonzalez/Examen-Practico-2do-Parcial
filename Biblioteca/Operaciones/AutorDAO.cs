using Biblioteca.Context;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Operaciones
{
    public class AutorDAO
    {
        //Crea un objeto de contexto de DB
        public Examen2Context contexto = new Examen2Context();

        //metodo para seleccionar a todos los autores
        public List<Autor> seleccionarTodos()
        {
            var autors = contexto.Autors.ToList<Autor>();
            return autors;
        }
        //metodo para añadir a un profesor a la BD
        public bool insertar(int id, string nombre)
        {
            try
            {
                Autor autor = new Autor();
                autor.Id = id;
                autor.Name = nombre;

                contexto.Autors.Add(autor);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
