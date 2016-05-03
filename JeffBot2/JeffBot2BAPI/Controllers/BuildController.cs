using JeffBot2Tools.Helpers;
using JeffBot2Tools;
using System.Web.Http;
using JeffBot2.Models;

namespace JeffBot2BAPI.Controllers
{
    public class BuildController : ApiController
    {
        private NcDBContext db = new NcDBContext();

        public string Get([FromUri]string arg)
        {
            string carg = Sanitizer.clean(arg);
            return SentenceBuilder.build(db, carg);
        }

        public string Post([FromBody]string arg)
        {
            string carg = Sanitizer.clean(arg);
            return SentenceBuilder.build(db, carg);
        }
    }
}
