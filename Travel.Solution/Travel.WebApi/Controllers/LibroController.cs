using System.Threading.Tasks;
using System.Web.Http;
using Travel.Core.LogicaNegocio.Implementacion;
using Travel.Core.LogicaNegocio.Interface;

namespace Travel.WebApi.Controllers
{
    public class LibroController : ApiController
    {
        ILibroService LibroService = new LibroService();

        [HttpGet]
        [Route("api/Libro/Libro_ObtAll")]
        public async Task<IHttpActionResult> Libro_ObtAll()
        {
            return Ok(LibroService.Libro_ObtAll());
        }

        [HttpGet]
        [Route("api/Libro/Libro_ObtUno")]
        public async Task<IHttpActionResult> Libro_ObtUno(double ISBN)
        {
            return Ok(LibroService.Libro_ObtUno(ISBN));
        }

        [HttpGet]
        [Route("api/Libro/Libro_Insertar")]
        public async Task<IHttpActionResult> Libro_Insertar(double ISBN, double Editorial_Id, string Titulo, string Sinopsis, string NPaginas)
        {
            return Ok(LibroService.Libro_Insertar(ISBN, Editorial_Id, Titulo, Sinopsis, NPaginas));
        }

        [HttpGet]
        [Route("api/Libro/Libro_Actualizar")]
        public async Task<IHttpActionResult> Libro_Actualizar(double ISBN, double Editorial_Id, string Titulo, string Sinopsis, string NPaginas)
        {
            return Ok(LibroService.Libro_Actualizar(ISBN, Editorial_Id, Titulo, Sinopsis, NPaginas));
        }
    }
}
