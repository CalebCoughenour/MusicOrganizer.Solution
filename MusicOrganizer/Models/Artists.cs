namespace MusicOrganizer.Models
{
  public class Artist
  {
    public string Name { get; set; }
    public List<Album> Albums { get; set; };
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
      return _albums;
    }
    public static GetArtists()
    {
      return _artists;
    }
  }
}