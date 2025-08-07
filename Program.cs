/// <summary>
/// This is the interface of the program.
/// </summary>
using POOProjectMusicAndPodcast.Menus;
using POOProjectMusicAndPodcast.Models;


Artist ira = new Artist("Ira");
ira.AddScore(new Ranking(10));
ira.AddScore(new Ranking(8));
ira.AddScore(new Ranking(6));
Artist beatles = new("The Beatles");

Dictionary<string, Artist> artistRegistered = new();
artistRegistered.Add(ira.Name, ira);
artistRegistered.Add(beatles.Name, beatles);

Dictionary<int, Menu> options = new();
options.Add(1, new MenuArtistProfile());
options.Add(2, new MenuAlbumProfile());
options.Add(3, new MenuShowArtists());
options.Add(4, new MenuArtistScore());
options.Add(5, new MenuShowInformations());
options.Add(-1, new MenuLogOff());

void ExibirLogo()
{
    Console.WriteLine(@"
███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░  ░█████╗░███╗░░██╗██████╗░
████╗░████║██║░░░██║██╔════╝██║██╔══██╗  ██╔══██╗████╗░██║██╔══██╗
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝  ███████║██╔██╗██║██║░░██║
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗  ██╔══██║██║╚████║██║░░██║
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝  ██║░░██║██║░╚███║██████╔╝
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░  ╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░

██████╗░░█████╗░██████╗░░█████╗░░█████╗░░██████╗████████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝
██████╔╝██║░░██║██║░░██║██║░░╚═╝███████║╚█████╗░░░░██║░░░
██╔═══╝░██║░░██║██║░░██║██║░░██╗██╔══██║░╚═══██╗░░░██║░░░
██║░░░░░╚█████╔╝██████╔╝╚█████╔╝██║░░██║██████╔╝░░░██║░░░
╚═╝░░░░░░╚════╝░╚═════╝░░╚════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░
");
    Console.WriteLine("Welcome to Music and Podcast!");
}

void ShowMenuOptions()
{
    ExibirLogo();
    Console.WriteLine("\nPress 1 to register an artist");
    Console.WriteLine("Press 2 to register a album for the artista");
    Console.WriteLine("Press 3 to show all the artists");
    Console.WriteLine("Press 4 to take a score for the artist");
    Console.WriteLine("Press 5 to show informations about the artist");
    Console.WriteLine("Press -1 for get out");

    Console.Write("\nWhat's your option? ");
    string theOption = Console.ReadLine()!;
    int numberTheOption = int.Parse(theOption);

    if (options.ContainsKey(numberTheOption))
    {
        Menu menuASerExibido = options[numberTheOption];
        menuASerExibido.Execute(artistRegistered);
        if (numberTheOption > 0) ShowMenuOptions();
    }
    else
    {
        Console.WriteLine("Invalid Option");
    }
}

ShowMenuOptions();
