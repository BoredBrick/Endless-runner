using Assets.Scripts;
using System.Collections;
using UnityEngine;

public class ChangeSpeed : BasePickUp
{
    public int speed;

    public override void StartEffect()
    {
        StartCoroutine(SpeedChange());
    }

    IEnumerator SpeedChange()
    {
        PlayerMove.moveSpeed = speed;
        yield return new WaitForSecondsRealtime(10f);
        PlayerMove.moveSpeed = Constants.defaultMoveSpeed;
        yield return null;
    }
}
