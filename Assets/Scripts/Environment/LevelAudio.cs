using UnityEngine;

public class LevelAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    void Start()
    {
        audioSource.volume = 0.09f;
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.Play();
    }

    public void Death()
    {
        audioSource.volume = 0.045f;
    }
}
