using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace cms.Models
{
    public class Blog
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Blog Title")]
        public string title { get; set; }

        [AllowHtml]
        [Display(Name = "Blog Content")]
        public string description { get; set; }
        public List<string> blogList { get; set; }
    }
}