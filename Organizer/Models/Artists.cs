using System.Collections.Generic;

namespace Organizer.Models
{
  public class Artist
  {
    public string Name { get; set; }
    public List<Album> Albums { get; set; }
    private static List<Artist> _artists = new List<Artist>{};
  
    public Artist(string name)
    {
      Name = name;     
      _artists.Add(this);
      Albums = new List<Album>{};
    }
    public void AddAlbum(Album album)
    {
      Albums.Add(album);
    }
    public List<Album> DisplayAlbums()
    {
      return Albums;
    }
    public static List<Artist> GetArtists()
    {
      return _artists;
    }
    
    public static Artist FindArtist(string name)
    {
      foreach (Artist artist in _artists)
      {
        if (name == artist.Name)
        {
          return artist;
        }
      }
      return null;
    }
  }
}