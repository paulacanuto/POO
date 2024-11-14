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
        Console.WriteLine($"Complet list of the album {Name}:\n");
        foreach (var music in musics)
        {
            Console.WriteLine($"Music: {music.Name}");
        }
        Console.WriteLine($"\nIf you want to listen all the musics off this album, you need a {AlbumTime} minutes");
    }
}