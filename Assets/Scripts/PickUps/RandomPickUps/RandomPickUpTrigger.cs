using UnityEngine;

public class RandomPickUpTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("Scripts").GetComponent<RandomPickUps>().TriggerEffect();
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
