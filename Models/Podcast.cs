namespace POOProjectMusicAndPodcast.Models;

internal class Podcast
{
    public Podcast(Artist episode = new List<Episode>();

    public Podcast(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int PodcastTime => episode.Sum(m => m.PodcastTime);
    public List<Episode> Episode => episode;

    public void AdicionarMusica(Episode episode)
    {
        episode.Add(episode);
    }

    public void ShowPodcastEpisodes()
    {
        Console.WriteLine($"Lista de episódios do podcast {Name}:\n");
        foreach (var episode in episode)
        {
            Console.WriteLine($"Música: {episode.Name}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {AlbumTime}");
    }
}