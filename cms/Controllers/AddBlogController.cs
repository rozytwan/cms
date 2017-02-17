using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;
using cms.Models;
namespace cms.Controllers
{
    public class AddBlogController : Controller
    {
        // GET: AddBlog
        public ActionResult Index()
        {
            return View("AddBlog");
        }

        //ajasdjasdj
        public ActionResult save(cms.Models.Blog blg)
        {
            #region old

            /*if (ModelState.IsValid)
            {
                string FileName = ab.fileName;
                string data = ab.Content;
                Markdown md = new Markdown();
                var html = md.Transform(data);
                StreamWriter sr = new StreamWriter(Server.MapPath("/blogFiles/" + FileName + ".htm"), true);
                sr.WriteAsync(html);
                sr.Close();

                string str;
                using (StreamReader sreader = new StreamReader(Server.MapPath("/blogFiles/blog.dat")))
                {
                    str = sreader.ReadToEnd();
                }
                string[] frs = str.Split('|');
                int a = Convert.ToInt32(frs[0]);
                a++;
                System.IO.File.Delete(Server.MapPath("/blogFiles/blog.dat"));
                string today = DateTime.Now.ToShortDateString();
                using (StreamWriter swriter = new StreamWriter(Server.MapPath("/blogFiles/blog.dat"), false))
                {
                    string strn = a + "|" + FileName + "|" + FileName + "|" + FileName + ".htm" + "|" + today;
                    swriter.Write(strn);
                    swriter.Write(Environment.NewLine);
                    swriter.Write(str);
                }
            }*/
            #endregion
            IdentityModels db = new IdentityModels();
            Blog objBlog = new Blog();
            objBlog.title = blg.title;
            objBlog.description = blg.description;
            db.dbBlog.Add(objBlog);
            db.SaveChanges();
            return View("AddBlog");

        }
    }
}

