using POOProjectMusicAndPodcast.Models;
namespace POOProjectMusicAndPodcast.Menus
{
    internal class MenuShowInformations : Menu
    {
        public override void Execute(Dictionary<string, Artist> artistRegistered)
        {
            base.Execute(artistRegistered);
            ShowOptionsTitle("Show informations about the artist.");
            Console.Write("What the artist do you want to know more about? ");
            string artistName = Console.ReadLine()!;
            if (artistRegistered.ContainsKey(artistName))
            {
                Artist artist = artistRegistered[artistName];
                Console.WriteLine($"\nThe artist {artistName} have {artist.Average} in score.");
                /**
                * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
                */
                Console.WriteLine("Press any key to return the menu:");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nThe artist {artistName} was not found!");
                Console.WriteLine("Press any key to return the menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}