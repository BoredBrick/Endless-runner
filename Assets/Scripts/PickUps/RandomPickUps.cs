using System.Collections.Generic;
using UnityEngine;

public class RandomPickUps : MonoBehaviour
{
    public List<BasePickUp> pickUps;

    public void TriggerEffect()
    {
        pickUps[3].StartEffect();

    }
}
