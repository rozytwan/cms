using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cms.Models;

namespace cms.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        public ActionResult Index()
        {

            IdentityModels db = new IdentityModels();
            List<Blog> bloglist = db.dbBlog.ToList();
            return View("index",bloglist);
        }
    }
}