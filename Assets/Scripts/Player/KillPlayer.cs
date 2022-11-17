using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider obstacle)
    {
        if (obstacle.CompareTag("Player"))
        {
        }
    }
}
