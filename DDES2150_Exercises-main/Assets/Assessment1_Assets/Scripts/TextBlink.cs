using UnityEngine;
using TMPro;

public class TextBlink : MonoBehaviour
{
    public TextMeshPro textObject;
    public float blinkSpeed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (textObject == null) return;

        Color c = textObject.color;
        c.a = Mathf.PingPong(Time.time * blinkSpeed, 1f);
        textObject.color = c;
    }
}
