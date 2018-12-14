using System.Net;
using System.Web.Configuration;
using System.Web.Http;
using Model;
using Domain;

namespace VirtualmindTest.Controllers
{
    public class DollarCotizacionController : ApiController
    {
        private readonly string _urlDolar = WebConfigurationManager.AppSettings["UrlDolar"];

        // GET: api/DollarCotizacion
        public IHttpActionResult GetDollarCotization(Dolar currency)
        {
            if (currency == null)
                return StatusCode(HttpStatusCode.NoContent);

            return Ok(Context.GetCotization(currency, _urlDolar));
        }
    }
}
