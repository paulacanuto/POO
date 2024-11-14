using POOProjectMusicAndPodcast.Models;

namespace POOProjectMusicAndPodcast.Menus;

internal class MenuShowArtists : Menu
{
    public override void Execute(Dictionary<string, Artist> artistRegistered)
    {
        base.Execute(artistRegistered);
        ShowOptionsTitle("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string artist in artistRegistered.Keys)
        {
            Console.WriteLine($"Banda: {artist}");
        }

        Console.WriteLine("\nPress any key to return the menu:");
        Console.ReadKey();
        Console.Clear();
    }
}
