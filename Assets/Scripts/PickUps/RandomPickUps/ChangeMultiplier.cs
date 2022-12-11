using Assets.Scripts;
using System.Collections;
using UnityEngine;

public class ChangeMultiplier : BasePickUp
{
    public override void StartEffect()
    {
        Debug.Log(Constants.PointsMultiplier);
        Constants.PointsMultiplier *= 2;
        Debug.Log(Constants.PointsMultiplier);
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(10f);
        Constants.PointsMultiplier /= 2;
    }
}
