using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickListener : MonoBehaviour
{
    public GameObject videoObject, audioObject, offButton, onButton, stopButton;

    // Start is called before the first frame update
    void Start()
    {
        stopButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Button Clicked");
        StopAllAudio();
        videoObject.SetActive(true);
        audioObject.SetActive(true);
        offButton.SetActive(false);
        onButton.SetActive(true);
    }

    void Awake()
    {
        allAudioSources = Resources.FindObjectsOfTypeAll(typeof(AudioSource)) as AudioSource[];
    }

    private AudioSource[] allAudioSources;
    void StopAllAudio()
    {
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }
}
