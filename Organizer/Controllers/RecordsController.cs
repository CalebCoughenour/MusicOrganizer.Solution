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
    public ActionResult New()
    {
      List<Artist> artists = Artist.GetArtists();
      return View(artists);
    }
    [HttpPost("/records")]
    public ActionResult New(string albumName, string artist)
    {
      Album album = new Album(albumName, artist);
      List<Artist> artists = Artist.GetArtists();
      foreach(Artist artist in artists)
      {
        if(artist.Name == artist)
        {
          artist.Albums.add(album);
        }
      }
      return RedirectToAction("Show");
    }
  }
}
    [HttpGet("/categories/{categoryId}/items/new")]
    public ActionResult New(int categoryId)
    {
      Category category = Category.Find(categoryId);
      return View(category);
    }