/// <summary>
/// This class is about podcasts.
/// </summary>
namespace POOProjectMusicAndPodcast.Models;

internal class Podcast
{
    private List<Episode> episodes = new List<Episode>();

    public Podcast(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int PodcastTime => episodes.Sum(m => m.EpTime);
    public List<Episode> Episodes => episodes;

    public void AdicionarMusica(Episode episode)
    {
        episodes.Add(episode);
    }

    public void ShowPodcastEpisodes()
    {
        Console.WriteLine($"Episode list of Podcast {Name}:\n");
        foreach (var episode in episodes)
        {
            Console.WriteLine($"Episode: {episode.Name}");
        }
        Console.WriteLine($"\nIf you want to listen all the episodes off this podcast, you need a{PodcastTime} minutes.");
    }
}