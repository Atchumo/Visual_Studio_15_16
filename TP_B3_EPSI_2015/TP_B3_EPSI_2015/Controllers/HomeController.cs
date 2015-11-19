using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP_B3_EPSI_2015.Models;

namespace TP_B3_EPSI_2015.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Album> liste;
            using (var db = new DataAccess.DataAccess())
            {
                liste = db.Liste();
            }
            return View(liste);
        }
    }
}