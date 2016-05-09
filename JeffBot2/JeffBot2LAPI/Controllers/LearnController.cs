using JeffBot2.Models;
using JeffBot2Tools;
using JeffBot2Tools.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JeffBot2LAPI.Controllers
{
    public class LearnController : ApiController
    {
        private NcDBContext db = new NcDBContext();

        public string Get([FromUri]string arg)
        {
            foreach (string varg in Sanitizer.splitSentences(arg))
            {
                string carg = Sanitizer.clean(varg);
                try
                {
                    Learner.commit(db, Ngram.split(3, carg));
                }
                catch (NotEnoughTokensException e)
                {
                    // Not enough tokens to commence learning.
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }
            return "200";
        }

        public string Post([FromBody]string arg)
        {
            foreach (string varg in Sanitizer.splitSentences(arg))
            {
                string carg = Sanitizer.clean(varg);
                try
                {
                    Learner.commit(db, Ngram.split(3, carg));
                }
                catch (NotEnoughTokensException e)
                {
                    // Not enough tokens to commence learning.
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }
            return "200";
        }
    }
}
