/// <summary>
/// This class is about ranking.
/// </summary>
namespace POOProjectMusicAndPodcast.Models;

internal class Ranking
{
    public Ranking(int score)
    {
        Score = score;
    }

    public int Score { get; }

    public static Ranking Parse(string texto)
    {
        int score = int.Parse(texto);
        return new Ranking(score);
    }
}