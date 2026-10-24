using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip1;
    }

    // Update is called once per frame
    void Update()
    {
        ToggleAudio();
    }

    void ToggleAudio()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
            else
            {
                audioSource.Play();
            }
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            audioSource.loop = !audioSource.loop;
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            audioSource.Stop();
            audioSource.clip = clip1;
            audioSource.Play();
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            audioSource.Stop();
            audioSource.clip = clip2;
            audioSource.Play();
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            audioSource.Stop();
            audioSource.clip = clip3;
            audioSource.Play();
        }
    }
}
