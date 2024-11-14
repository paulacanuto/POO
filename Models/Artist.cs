namespace POOProjectMusicAndPodcast.Models;

internal class Artist
{
   // private string ArtistName;
   // private int ArtistIdade;
    private List<Album> albuns = new List<Album>();
    private List<Ranking> scores = new List<Ranking>();
  
    public Artist(string name)
    {
        Name = name;
    }
    // public string NameArtist
    //{
    //    get { return NameArtist; }
    //       private set { NameArtist = value; }
    //  }

    //  public Artist(string name)
    //  {
    //      ArtistName = name;
    //      ArtistIdade = 0;
    //  }

    public string Name { get; }
    public double Average
    {
        get
        {
            if (scores.Count == 0) return 0;
            else return scores.Average(a => a.Score);
        }
    }
    public List<Album> Albuns => albuns;

    public void AddAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void AddScore(Ranking score)
    {
        scores.Add(score);
    }

    public void ShowDiscograph()
    {
        Console.WriteLine($"Discografia da banda {Name}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Name} ({album.AlbumTime})");
        }
    }
}