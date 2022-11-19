using System.Collections;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    public static int score = 0;
    public TMP_Text counter;
    void Start()
    {
        score = 0;
        StartCoroutine(UpdateScore());
    }

    IEnumerator UpdateScore()
    {
        while (true)
        {
            counter.text = score.ToString();
            score++;
            yield return new WaitForSeconds(1f);
        }
    }
}
