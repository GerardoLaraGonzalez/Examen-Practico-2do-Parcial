using Biblioteca.Context;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Operaciones
{
    public class LibroDAO
    {
        //Crea un objeto de contexto de DB
        public Examen2Context contexto = new Examen2Context();

        //metodo para seleccionar a todos los libros
        public List<Libro> seleccionarTodos()
        {
            var libros = contexto.Libros.ToList<Libro>();
            return libros;
        }

        //metodo para seleccionar a todos los libros
        public Libro seleccionar(int idLibro)
        {
            var libros = contexto.Libros.Where(a => a.Id == idLibro).FirstOrDefault();
            return libros;
        }

        //Metodo para añadir nuevo libro
        public bool insertar(int id, string title, int chapters, int pages, int price, int autor_id)
        {
            try
            {
                Libro libro = new Libro();
                libro.Id = id;
                libro.Title = title;
                libro.Chapters = chapters;
                libro.Pages = pages;
                libro.Price = price;
                libro.AuthorId = autor_id;

                contexto.Libros.Add(libro);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //metodo para obtener la lista de libros y sus autores
        public List<LibroAutor> seleccionarLibroAutor()
        {
            var query = from a in contexto.Libros
                        join m in contexto.Autors on a.AuthorId equals m.Id
                        select new LibroAutor
                        {
                            NombreLibro = a.Title,
                            NombreAutor = m.Name,
                            Chapters = a.Chapters,
                            Pages = a.Pages,
                            Price = a.Price
                        };
            return query.ToList();
        }

    }
}
