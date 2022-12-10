using UnityEngine;

public class KillPlayer : MonoBehaviour
{

    private void OnTriggerEnter(Collider obstacle)
    {
        if (obstacle.CompareTag("Player"))
        {
            GameOver gameOverScreen = GameObject.Find("Scripts").GetComponent<GameOver>();
            gameOverScreen.Display(Points.score);
        }
    }
}
