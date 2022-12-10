using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseScreen;

    private void Update()
    {

        if ((Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)) && Countdown.isPlaying)
        {
            if (pauseScreen.activeSelf)
            {
                Time.timeScale = 1;
                pauseScreen.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                pauseScreen.SetActive(true);
            }
        }
    }
}
