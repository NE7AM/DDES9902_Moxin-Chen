using UnityEngine;

public class PlayOnceSound : MonoBehaviour
{
    public VoiceDelayed delayedPlayer;
    private bool hasPlayed = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TriggerSound()
    {
        if (hasPlayed) return;

        delayedPlayer.PlayDelayed();
        hasPlayed = true;
    }
}
