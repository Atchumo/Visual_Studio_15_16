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

            string connexion = ConfigurationManager.ConnectionStrings["LocalMySqlServer"].ConnectionString;

            List<Album> maListeAlbums = new List<Album>();
            maListeAlbums.Add(new Album()
            {
                titre = "Black Ice",
                auteur = "AC/DC",
                genre = "Hard Rock",
                annee_sortie = 2008
            });
            maListeAlbums.Add(new Album()
            {
                titre = "Thriller",
                auteur = "Micheal Jackson",
                genre = "Pop",
                annee_sortie = 1982
            });
            maListeAlbums.Add(new Album()
            {
                titre = "Random Access Memories",
                auteur = "Daft Punk",
                genre = "Electro/Funk/Disco",
                annee_sortie = 2013
            });
            return View(maListeAlbums);
        }
    }
}