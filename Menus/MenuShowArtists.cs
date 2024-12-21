/// <summary>
/// This class is a menu to view informations about the artists.
/// </summary>
using POOProjectMusicAndPodcast.Models;

namespace POOProjectMusicAndPodcast.Menus;

internal class MenuShowArtists : Menu
{
    public override void Execute(Dictionary<string, Artist> artistRegistered)
    {
        base.Execute(artistRegistered);
        ShowOptionsTitle("Show all the artists registered");

        foreach (string artist in artistRegistered.Keys)
        {
            Console.WriteLine($"Artist: {artist}");
        }

        Console.WriteLine("\nPress any key to return the menu:");
        Console.ReadKey();
        Console.Clear();
    }
}
