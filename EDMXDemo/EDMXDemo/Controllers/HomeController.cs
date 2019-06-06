using EDMX.Models;
using EDMX.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EDMXDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            
            using(var context=new tptoolkitEntities())
            {
                var list = context.Brand.ToList();
                var sql = "select Id,Name from Brand";
                var list2 = context.Database.SqlQuery<BrandDto>(sql).ToList();
            }

            return View();
        }
    }
}
