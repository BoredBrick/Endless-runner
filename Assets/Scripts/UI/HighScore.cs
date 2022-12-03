using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    List<int> scores = new();
    public const int MAX_SCORES = 5;
    public HighScoreDisplay[] highScoreDisplayArray;
    public void AddNewScore(int score)
    {
        scores.Add(score);
        scores.Sort((int x, int y) => y.CompareTo(x));
        scores.RemoveRange(MAX_SCORES, scores.Count - MAX_SCORES);
    }

    public void ShowScore()
    {
        for (int i = 0; i < highScoreDisplayArray.Length; i++)
        {
            if (i < scores.Count)
            {
                highScoreDisplayArray[i].DisplayHighScore(scores[i]);
            }
            else
            {
                highScoreDisplayArray[i].HideEntryDisplay();
            }
        }
    }
}
