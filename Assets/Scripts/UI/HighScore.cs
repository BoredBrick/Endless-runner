using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public static List<int> scores = new();
    public const int MAX_SCORES = 5;
    public HighScoreDisplay[] highScoreDisplayArray;

    public void Awake()
    {
        ShowScore();
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
