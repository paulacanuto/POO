namespace POOProjectMusicAndPodcast.Models;

internal class Episode  
{
    public Episode(Artist artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    public string Name { get; }
    public Artist Artist{ get; }
public int EpTime { get; set; }
public bool Available { get; set; }
public string DescricaoResumida => $"This {Name} is from {Artist.Name}";

public void ExibirFichaTecnica()
{
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"Artist: {Artist.Name}");
    Console.WriteLine($"Time: {EpTime}");
    if (Available)
    {
        Console.WriteLine("Disponível no plano.");
    }
    else
    {
        Console.WriteLine("Adquira o plano Plus+");
    }
}
}