using Biblioteca.Models;
using Biblioteca.Operaciones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private AutorDAO autorDAO = new AutorDAO();

        //end point para todos los autores
        [HttpGet("Autores")]
        public List<Autor> getAutores()
        {
            return autorDAO.seleccionarTodos();
        }
        /*
         *
         * Endpoint para agregar un nuevo autor a la BD*/
        [HttpPost("Autores")]
        public bool insertarAutor([FromBody] Autor autor)
        {
            return autorDAO.insertar(autor.Id, autor.Name);
        }
    }
}
