using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixerSFX;
    public AudioMixer audioMixerMusic;
    public AudioMixer audioMixerDialogue;
    public float S;
    public float M;
    public float D;
 
    public void SetVolumeS(float volumeS)
    {
        PlayerPrefs.SetFloat("SFXp", volumeS);
        S = PlayerPrefs.GetFloat("SFXp");
        audioMixerSFX.SetFloat("SFX", S);
    }
    public void SetVolumeM(float volumeM)
    {
        PlayerPrefs.SetFloat("Musicp", volumeM);
        M = PlayerPrefs.GetFloat("Musicp");
        audioMixerMusic.SetFloat("Music", M);
    }
    public void SetVolumeD(float volumeD)
    {
        PlayerPrefs.SetFloat("Dialoguep", volumeD);
        D = PlayerPrefs.GetFloat("Dialoguep");
        audioMixerMusic.SetFloat("Dialogue", D);
    }


}

