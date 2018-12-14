using System.Net;
using System.Web.Configuration;
using System.Web.Http;
using Model;
using Domain;

namespace VirtualmindTest.Controllers
{
    public class RealCotizationController : ApiController
    {
        private readonly string _urlReal = WebConfigurationManager.AppSettings["UrlReal"];

        // GET: api/RealCotization
        public IHttpActionResult GetRealCotization(Real currency)
        {
            return StatusCode(HttpStatusCode.Unauthorized);
        }
    }
}
