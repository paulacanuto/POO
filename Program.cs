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

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuArtistProfile());
opcoes.Add(2, new MenuAlbumProfile());
opcoes.Add(3, new MenuShowArtists());
opcoes.Add(4, new MenuArtistScore());
opcoes.Add(5, new MenuShowInformations());
opcoes.Add(-1, new MenuLogOff());

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
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Execute(artistRegistered);
        if (opcaoEscolhidaNumerica > 0) ShowMenuOptions();
    }
    else
    {
        Console.WriteLine("Invalid Option");
    }
}

ShowMenuOptions();
