namespace POOProjectMusicAndPodcast.Models;

internal class Album
{
    private List<Music> musics = new List<Music>();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int AlbumTime => musics.Sum(m => m.MusicTime);
    public List<Music> Musics => musics;

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowMusicsAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Name}:\n");
        foreach (var music in musics)
        {
            Console.WriteLine($"Música: {music.Name}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {AlbumTime}");
    }
}