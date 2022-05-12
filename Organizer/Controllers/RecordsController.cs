using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Organizer.Models;

namespace Organizer.Controllers
{
  public class RecordsController : Controller
  {
    [HttpGet("/records")]
    public ActionResult Show()
    {
      List<Artist> artists = Artist.GetArtists();
      return View(artists);
    }
    [HttpGet("/artist/{artistName}/record/new")]
    public ActionResult New(string artistName)
    {
      // List<Artist> artists = Artist.GetArtists();
      return View(artistName);
    }
  }
}