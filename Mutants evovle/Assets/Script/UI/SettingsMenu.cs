using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixerSFX;
    public AudioMixer audioMixerMusic;
    public AudioMixer audioMixerDialogue;
 
    public void SetVolumeS(float volumeS)
    {
        audioMixerSFX.SetFloat("SFX", volumeS);
    }
    public void SetVolumeM(float volumeM)
    {
        audioMixerMusic.SetFloat("Music", volumeM);
    }
    public void SetVolumeD(float volumeD)
    {
        audioMixerDialogue.SetFloat("Dialogue", volumeD);
    }


}

