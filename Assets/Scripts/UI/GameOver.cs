using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TMP_Text finalPoints;
    public GameObject deathScreen;
    public HighScoreManager manager;
    public XMLHighScoreManager XMLManager;
    public void Awake()
    {
        XMLManager = ScriptableObject.CreateInstance<XMLHighScoreManager>();
        manager = ScriptableObject.CreateInstance<HighScoreManager>();
    }
    public void Display(int score)
    {
        manager.AddNewScore(score);
        Time.timeScale = 0;
        deathScreen.SetActive(true);
        finalPoints.text = score.ToString() + " POINTS";
    }

    public void Restart()
    {
        SceneManager.LoadScene("InfinityRunner");
        Points.score = 0;
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        XMLManager.SaveScores();
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
