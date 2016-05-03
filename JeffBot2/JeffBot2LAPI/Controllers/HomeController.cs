using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JeffBot2LAPI.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "API is online. Response code: 200";
        }
    }
}
