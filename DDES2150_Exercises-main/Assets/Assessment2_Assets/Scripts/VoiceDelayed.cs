using UnityEngine;

public class VoiceDelayed : MonoBehaviour
{
    public AudioSource audioSource;
    public float delay = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayDelayed()
    {
        Invoke(nameof(PlayNow), delay);
    }

    void PlayNow()
    {
        audioSource.Play();
    }
}
