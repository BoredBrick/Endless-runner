using System.Collections;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    private int score = 0;
    public TMP_Text counter;
    void Start()
    {
        Debug.Log("POITNS" + score);
        StartCoroutine(UpdateScore());
    }

    IEnumerator UpdateScore()
    {
        counter.text = score.ToString();
        score++;
        yield return new WaitForSeconds(1f);
    }
}
