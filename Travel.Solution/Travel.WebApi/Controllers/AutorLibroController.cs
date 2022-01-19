using System.Threading.Tasks;
using System.Web.Http;
using Travel.Core.LogicaNegocio.Implementacion;
using Travel.Core.LogicaNegocio.Interface;

namespace Travel.WebApi.Controllers
{
    public class AutorLibroController : ApiController
    {
        IAutorLibroService AutorLibroService = new AutorLibroService();

        [HttpGet]
        [Route("api/AutorLibro/AutorLibro_ObtAll")]
        public async Task<IHttpActionResult> AutorLibro_ObtAll()
        {
            return Ok(AutorLibroService.AutorLibro_ObtAll());
        }

        [HttpGet]
        [Route("api/AutorLibro/AutorLibro_ObtUno")]
        public async Task<IHttpActionResult> AutorLibro_ObtUno(double Autor_Id, double Libro_ISBN)
        {
            return Ok(AutorLibroService.AutorLibro_ObtUno(Autor_Id, Libro_ISBN));
        }

        [HttpGet]
        [Route("api/AutorLibro/AutorLibro_Insertar")]
        public async Task<IHttpActionResult> AutorLibro_Insertar(double Autor_Id, double Libro_ISBN)
        {
            return Ok(AutorLibroService.AutorLibro_Insertar(Autor_Id, Libro_ISBN));
        }
    }
}
