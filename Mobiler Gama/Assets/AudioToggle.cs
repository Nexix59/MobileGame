using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using System;

public class AudioToggle : MonoBehaviour
{

    public AudioMixer audioBruh;
    public AudioMixer audioDude;
    private Component IsOn;
    public Toggle audioToggle;

    public void audioStuff(bool IsOn)
    {
        if (IsOn == true)
        {

            audioDude.SetFloat("AudioMane", 0);

        }
        else
        {
            audioDude.SetFloat("AudioMane", -80);
        }
    }

                //audioBruh.SetFloat("AudioMane"), (volume) * 1);
}
