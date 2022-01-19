using System.Threading.Tasks;
using System.Web.Http;
using Travel.Core.LogicaNegocio.Implementacion;
using Travel.Core.LogicaNegocio.Interface;

namespace Travel.WebApi.Controllers
{
    public class EditorialController : ApiController
    {
        IEditorialService EditorialService = new EditorialService();

        [HttpGet]
        [Route("api/Editorial/Editorial_ObtAll")]
        public async Task<IHttpActionResult> Editorial_ObtAll()
        {
            return Ok(EditorialService.Editorial_ObtAll());
        }

        [HttpGet]
        [Route("api/Editorial/Editorial_ObtUno")]
        public async Task<IHttpActionResult> Editorial_ObtUno(double ID)
        {
            return Ok(EditorialService.Editorial_ObtUno(ID));
        }

        [HttpGet]
        [Route("api/Editorial/Editorial_Insertar")]
        public async Task<IHttpActionResult> Editorial_Insertar(double ID, string Nombre, string Sede)
        {
            return Ok(EditorialService.Editorial_Insertar(ID, Nombre, Sede));
        }

        [HttpGet]
        [Route("api/Editorial/Editorial_Actualizar")]
        public async Task<IHttpActionResult> Editorial_Actualizar(double ID, string Nombre, string Sede)
        {
            return Ok(EditorialService.Editorial_Actualizar(ID, Nombre, Sede));
        }
    }
}
