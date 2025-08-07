/// <summary>
/// This class is a menu about score os the artists.
/// </summary>
using POOProjectMusicAndPodcast.Models;

namespace POOProjectMusicAndPodcast.Menus;

    internal class MenuArtistScore : Menu
    {
        public override void Execute(Dictionary<string, Artist> artistRegistered)
        {
            base.Execute(artistRegistered);
            ShowOptionsTitle("Artist Score");
            Console.Write("What the artist do you want to give a score? ");
            string artistName = Console.ReadLine()!;
            if (artistRegistered.ContainsKey(artistName))
            {
                Artist artist = artistRegistered[artistName];
                Console.Write($"Give a number (0-10) to the {artistName}: ");
                Ranking score = Ranking.Parse(Console.ReadLine()!);
                artist.AddScore(score);
                Console.WriteLine($"\nThe {score.Score} was registered for {artistName}");
                Thread.Sleep(2000);
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
