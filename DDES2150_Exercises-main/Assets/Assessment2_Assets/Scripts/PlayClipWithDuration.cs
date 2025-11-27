using UnityEngine;
using System.Collections;

public class PlayClipWithDuration : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound(float seconds)
    {
        audioSource.time = 0f;
        audioSource.Play();
        StartCoroutine(StopAfter(seconds));
    }

    IEnumerator StopAfter(float t)
    {
        yield return new WaitForSeconds(t);
        audioSource.Stop();
    }
}
