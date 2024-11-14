using POOProjectMusicAndPodcast.Models;

namespace POOProjectMusicAndPodcast.Menus;

    internal class MenuArtistProfile : Menu
    {
        public override void Execute(Dictionary<string, Artist> artistRegistered)
        {
            base.Execute(artistRegistered);
            ShowOptionsTitle("Artist Profile");
            Console.Write("What the artist do you to register? ");
            string artistName = Console.ReadLine()!;
            Artist artist = new Artist(artistName);
            artistRegistered.Add(artistName, artist);
            Console.WriteLine($"The artist {artistName} was registered!");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
