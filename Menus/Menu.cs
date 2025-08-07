/// <summary>
/// This class is to use in another menus.
/// </summary>
using POOProjectMusicAndPodcast.Models;

namespace POOProjectMusicAndPodcast.Menus;

internal class Menu
{
    public static void ShowOptionsTitle(string title)
    {
        int numberOfLetters = title.Length;
        string symbols = string.Empty.PadLeft(numberOfLetters, '*');
        Console.WriteLine(symbols);
        Console.WriteLine(title);
        Console.WriteLine(symbols + "\n");
    }
    public virtual void Execute(Dictionary<string, Artist> artistRegistered)
    {
        Console.Clear();
    }
}
