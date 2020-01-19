using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceDelay : MonoBehaviour
{
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio.volume = 0.5f;
        audio.PlayDelayed(10f); // delay 10 seconds
    }

    // Update is called once per frame
    void Update()
    {
        while (audio.volume < 1)
        {
            audio.volume += 0.1f * Time.deltaTime;
        }
    }
}
