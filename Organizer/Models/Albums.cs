namespace Organizer.Models
{
  public class Album 
  {
    public string Name { get; set; }
    public string ArtistName { get; set; }

    public Album(string name, string artistName)
    {
      Name = name;
      ArtistName = artistName;
    }
  }
}
