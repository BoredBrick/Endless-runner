using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TMP_Text finalPoints;
    public GameObject deathScreen;
    public PlayerMove playerMove;

    public void Display(int score)
    {
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
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
