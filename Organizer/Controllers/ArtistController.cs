using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Organizer.Models;

namespace Organizer.Controllers
{
  public class ArtistController : Controller
  {
    [HttpGet("/artist")]
    public ActionResult Index()
    {
      List<Artist> allArtists = Artist.GetArtists();
      return View(allArtists);
    }
    
    [HttpGet("/artist/new")]
    public ActionResult New()
    {
      return View();
    }
    
    [HttpGet("/artist/{artistName}")]
    public ActionResult Show(string artistName)
    {
      Artist artist = Artist.FindArtist(artistName);
      return View(artist);
    }
    [HttpPost("/artist")]
    public ActionResult Create(string artistName)
    {
      Artist newArtist = new Artist(artistName);
      return RedirectToAction("Index");
    }
    [HttpPost("/artist/{artistName}/records")]
    public ActionResult New(string albumName, string artistName)
    {
      Artist artist = Artist.FindArtist(artistName);
      Album album = new Album(albumName, artistName);
      artist.Albums.Add(album);
      return Redirect($"/artist/{artistName}");
    }
  }
}