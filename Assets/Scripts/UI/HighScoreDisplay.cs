using TMPro;
using UnityEngine;

public class HighScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;
    public void DisplayHighScore(int score)
    {
        scoreText.text = string.Format("{0:000000}", score);
    }
    public void HideEntryDisplay()
    {
        scoreText.text = "";
    }
}
