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
        public async Task<IHttpActionResult> GetCompanyByUser()
        {
            return Ok(AutorService.Autor_ObtAll());
        }
    }
}
