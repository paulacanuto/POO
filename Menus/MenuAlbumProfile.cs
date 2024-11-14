using POOProjectMusicAndPodcast.Models;

namespace POOProjectMusicAndPodcast.Menus;

internal class MenuAlbumProfile : Menu
{
    public override void Execute(Dictionary<string, Artist> artistRegistered)
    {
        base.Execute(artistRegistered);
        ShowOptionsTitle("Album Profile");
        Console.Write("What the band do you want to register a new album? ");
        string artistName = Console.ReadLine()!;
        if (artistRegistered.ContainsKey(artistName))
        {
            Console.Write("What the album name? ");
            string albumName = Console.ReadLine()!;
            Artist banda = artistRegistered[artistName];
            banda.AddAlbum(new Album(albumName));
            Console.WriteLine($"The album {albumName} from {artistName} was registered!");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nThe artist {artistName} was not found!");
            Console.WriteLine("Press any key to return the menu:");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
