using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookie.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // POST: Home
        [HttpPost]
        public ActionResult Index(string name)
        {
            List<string> names;
            if (Session["Names"] == null)
            {
                names = new List<string>();
            }
            else
            {
                names = (List<string>)Session["Names"]; // must type-cast Session
            }
            names.Add(name);
            Session["Names"] = names;

            return View();
        }
    }
}