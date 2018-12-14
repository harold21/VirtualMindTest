using System.Net;
using System.Web.Configuration;
using System.Web.Http;
using Model;
using Domain;

namespace VirtualmindTest.Controllers
{
    public class PesosCotizationController : ApiController
    {
        private readonly string _urlPesos = WebConfigurationManager.AppSettings["UrlPesos"];

        // GET: api/PesosCotization
        public IHttpActionResult GetPesosCotization(Pesos currency)
        {
            return StatusCode(HttpStatusCode.Unauthorized);
        }
    }
}
