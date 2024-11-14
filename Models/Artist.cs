namespace POOProjectMusicAndPodcast.Models;

internal class Artist
{

    private List<Album> albuns = new List<Album>();
    private List<Ranking> scores = new List<Ranking>();
  
    public Artist(string name)
    {
        Name = name;
    }

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
        Console.WriteLine($"Discograph of the artist {Name}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Album: {album.Name} ({album.AlbumTime})");
        }
    }
}