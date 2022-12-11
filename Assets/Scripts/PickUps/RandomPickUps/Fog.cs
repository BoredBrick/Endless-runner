using System.Collections;
using UnityEngine;

public class Fog : BasePickUp
{
    public static readonly float defaultFogDensity = 0.012f;
    public static readonly float effectFogDensity = 0.090f;

    public override void StartEffect()
    {
        StartCoroutine(FogFade());
    }

    IEnumerator FogFade()
    {
        while (true)
        {
            Debug.Log(RenderSettings.fogDensity <= effectFogDensity);
            Debug.Log(RenderSettings.fogDensity);
            RenderSettings.fogDensity += 0.01f * Time.deltaTime;
            Debug.Log(RenderSettings.fogDensity);
            Debug.Log(RenderSettings.fogDensity <= effectFogDensity);
        }

        yield return new WaitForSecondsRealtime(10);

        while (RenderSettings.fogDensity >= defaultFogDensity)
        {
            RenderSettings.fogDensity -= 0.011f * Time.deltaTime;
        }
        yield return null;
    }
}
