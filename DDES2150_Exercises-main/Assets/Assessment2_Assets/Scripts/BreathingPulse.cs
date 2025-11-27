using UnityEngine;

public class BreathingPulse : MonoBehaviour
{
    public float speed = 2f;
    public float scaleAmount = 0.15f;
    private Vector3 originalScale;
    public bool isActive = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isActive) return;

        float scale = 1 + Mathf.Sin(Time.time * speed) * scaleAmount;
        transform.localScale = originalScale * scale;
    }

    public void StartPulsing()
    {
        isActive = true;
    }

    public void StopPulsing()
    {
        isActive = false;
        transform.localScale = originalScale;
    }
}
