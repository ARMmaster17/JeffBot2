using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JeffBot2.Models;
using JeffBot2Tools;
using JeffBot2Tools.Helpers;

namespace JeffBot2.Controllers
{
    public class ApiController : Controller
    {
        private NcDBContext db = new NcDBContext();

        // GET: Api
        public string Index()
        {
            return "API is online";
        }
        [HttpPost]
        public string Web(string arg)
        {
            string carg = Sanitizer.clean(arg);
            try
            {
                Learner.commit(db, Ngram.split(3, carg));
            }
            catch(NotEnoughTokensException e)
            {
                // Not enough tokens to commence learning.
            }
            catch(Exception e)
            {
                return e.ToString();
            }
            return SentenceBuilder.build(db, carg);
        }
    }
}