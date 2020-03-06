using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopClickListener : MonoBehaviour
{
    public GameObject videoObject, audioObject, playButton, stopButton;
    private AudioSource[] allAudioSources;
    // Start is called before the first frame update
    void Start()
    {
        //stopButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        StopAllAudio();
        Debug.Log("Stop Button clicked");
        videoObject.SetActive(false);
        audioObject.SetActive(false);
        playButton.SetActive(true);
        stopButton.SetActive(false);
    }

    void Awake()
    {
        allAudioSources = FindObjectsOfTypeAll(typeof(AudioSource)) as AudioSource[];
    }

    void StopAllAudio()
    {
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }
}
