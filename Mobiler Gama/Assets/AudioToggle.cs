using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
using System;

public class AudioToggle : MonoBehaviour
{

    public AudioMixer audioBruh;
    public AudioMixer audioDude;


    public void SeatVolume (float volume)
    {

            audioBruh.SetFloat("AudioMane", volume = (0 * 1));

        //audioBruh.SetFloat("AudioMane"), (volume) * 1);
    }

    public void SestVolume (float volume)
    {
        audioDude.SetFloat("AudioMane", volume = (-80 * 1));
    }

    void Update()
    {
        
    }
}
