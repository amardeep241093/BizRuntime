using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NorthwindController : Controller
    {
        //context class are responsibilites of connection to database
        NorthWindContext db = new NorthWindContext();
        public ActionResult Index()
         {
             db.CategoriesTable.ToList();
             db.ProductsTable.ToList();
             return View();
          }
               
            
        }
    }
