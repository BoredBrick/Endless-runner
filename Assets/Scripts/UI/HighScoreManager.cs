using UnityEngine;

public class HighScoreManager : ScriptableObject
{
    public const int MAX_SCORES = 5;
    public void AddNewScore(int score)
    {
        HighScore.scores.Add(score);
        HighScore.scores.Sort((int x, int y) => y.CompareTo(x));
        if (HighScore.scores.Count > MAX_SCORES)
        {
            HighScore.scores.RemoveAt(MAX_SCORES);
        }
    }
}
