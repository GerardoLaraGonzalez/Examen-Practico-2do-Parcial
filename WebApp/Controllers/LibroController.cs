using Biblioteca.Models;
using Biblioteca.Operaciones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private LibroDAO libroDAO = new LibroDAO();
        //end point para todos los libros
        [HttpGet("Libros")]
        public List<Libro> getLibros()
        {
            return libroDAO.seleccionarTodos();
        }
        /*
         *
         * Endpoint para agregar un nuevo autor a la BD*/
        [HttpPost("Libros")]
        public bool insertarLibros([FromBody] Libro libro)
        {
            return libroDAO.insertar
                (libro.Id, libro.Title, libro.Chapters, libro.Pages, libro.Price, libro.AuthorId);
        }

        [HttpGet("Libro")]
        public Libro getlibro(int id)
        {
            return libroDAO.seleccionar(id);
        }

        [HttpGet("LibroAutor")]
        public List<LibroAutor> getLibrosAutor()
        {
            return libroDAO.seleccionarLibroAutor();
        }
    }
}
