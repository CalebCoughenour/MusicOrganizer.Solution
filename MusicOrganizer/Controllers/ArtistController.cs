using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Albums.Models;
using Artists.Models;

namespace MusicOrganizer.Controller
{
  public class ArtistsController : Controller
  {
    [HttpGet("/artists")]
    public ActionResult Show()
    {
      return View();
    }

    [HttpGet("/artists/{id}/albums")]
    public ActionResult Show()
    {
      return View();
    }
    
  }
}