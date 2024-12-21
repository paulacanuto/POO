/// <summary>
/// This class is about musics.
/// </summary>
namespace POOProjectMusicAndPodcast.Models;

internal class Music
{
    public Music(Artist artist, string name)
    {
        Artist = artist;
        Name = name;
    }

public string Name { get; }
public Artist Artist { get; }
public int MusicTime { get; set; }
public bool Available { get; set; }
public string Resume => $"The music {Name} from {Artist.Name}";

public void ExibirFichaTecnica()
{
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"Artist: {Artist.Name}");
    Console.WriteLine($"Time: {MusicTime}");
    if (Available)
    {
        Console.WriteLine("Available in your signature.");
    }
    else
    {
        Console.WriteLine("Add Plus signature now!");
    }
}
}


