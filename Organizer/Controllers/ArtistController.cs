using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Organizer.Models;

namespace Organizer.Controllers
{
  public class ArtistController : Controller
  {
    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artist> allArtists = Artist.GetArtists();
      return View(allArtists);
    }
    [HttpPost("/artists")]
    public ActionResult Create(string artistName)
    {
      Artist newArtist = new Artist(artistName);
      return RedirectToAction("Index");
    }
  }
}