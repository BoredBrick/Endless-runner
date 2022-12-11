using System.Collections.Generic;
using UnityEngine;

public class RandomPickUps : MonoBehaviour
{
    public List<BasePickUp> pickUps;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            pickUps[Random.Range(0, pickUps.Count)].StartEffect();
            gameObject.SetActive(false);
        }
    }
}
