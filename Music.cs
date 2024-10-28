using System.ComponentModel.Design;

class Music
{
    public string name;
    public string artist;
    public int time;
    public bool avabble;
    public void ShowTechnicalInfomation(){
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Artist: {artist}");
        Console.WriteLine($"Time: {time} seconds");
        if (avabble)
        {
            Console.WriteLine($"You can listen this song.");
        }
        else { 
            Console.WriteLine($"Add Plus+ pack right now!"); 
        }
    }
}