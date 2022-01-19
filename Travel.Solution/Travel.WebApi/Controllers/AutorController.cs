using System.Threading.Tasks;
using System.Web.Http;
using Travel.Core.LogicaNegocio.Implementacion;
using Travel.Core.LogicaNegocio.Interface;

namespace Travel.WebApi.Controllers
{
    public class AutorController : ApiController
    {
        IAutorService AutorService = new AutorService();

        [HttpGet]
        [Route("api/Autor/Autor_ObtAll")]
        public async Task<IHttpActionResult> Autor_ObtAll()
        {
            return Ok(AutorService.Autor_ObtAll());
        }

        [HttpGet]
        [Route("api/Autor/Autor_ObtUno")]
        public async Task<IHttpActionResult> Autor_ObtUno(double ID)
        {
            return Ok(AutorService.Autor_ObtUno(ID));
        }

        [HttpGet]
        [Route("api/Autor/Autor_Insertar")]
        public async Task<IHttpActionResult> Autor_Insertar(double ID, string Nombres, string Apellidos)
        {
            return Ok(AutorService.Autor_Insertar(ID, Nombres, Apellidos));
        }

        [HttpGet]
        [Route("api/Autor/Autor_Actualizar")]
        public async Task<IHttpActionResult> Autor_Actualizar(double ID, string Nombres, string Apellidos)
        {
            return Ok(AutorService.Autor_Actualizar(ID, Nombres, Apellidos));
        }
    }
}
