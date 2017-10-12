using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;

namespace CdOrganizer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View(Artist.GetAll());
        }

        [HttpPost("/cds/add")]
        public ActionResult AddCd()
        {
            string cdName = Request.Form["cd-name"];
            string artistName = Request.Form["cd-artist"];
            Cd newCd = new Cd(cdName, artistName);
            return Redirect("/");

        }

        [HttpPost("/artist/add")]
        public ActionResult AddArtist()
        {
            string artistName = Request.Form["cd-artist"];
            Artist newArtist = new Artist(artistName);
            return Redirect("/");
        }

        [HttpGet("/artist/{id}")]
        public ActionResult ArtistDetail(int id)
        {
           Artist artist = Artist.Find(id);
           return View(artist);
       }
    }
}
