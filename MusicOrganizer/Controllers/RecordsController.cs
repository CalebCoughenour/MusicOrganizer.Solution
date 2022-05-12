using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Albums.Models;
using Artists.Models;

namespace MusicOrganizer.Controller
{
  public class RecordsController : Controller
  {
    [HttpGet("/records")]
    public ActionResult Show()
    {
      return View();
    }
    [HttpGet("/records/new")]
    public ActionResult New()
    {
      List<Artist> artists = Artist.GetArtists();
      return View(artists);
    }
    [HttpPost("/records")]
    public ActionResult Create()
    {
      return RedirectToAction("Show")
    }
  }
}