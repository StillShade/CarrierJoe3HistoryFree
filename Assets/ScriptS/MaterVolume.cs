using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class MaterVolume : MonoBehaviour
{
    public AudioMixerGroup Mixer;
    public GameObject onVol;
    public GameObject offVol;

    private void Update()
    {
        if (Main.MasterVolume == 1) OnVolume();
        else if (Main.MasterVolume == 0) OffVolume();
    }
    public void OnVolume()
    {
        Mixer.audioMixer.SetFloat("MasterVolume", 0);
        onVol.SetActive(true);
        offVol.SetActive(false);
        Main.MasterVolume = 1;
    }
    public void OffVolume ()
    {
        Mixer.audioMixer.SetFloat("MasterVolume", -80);
        onVol.SetActive(false);
        offVol.SetActive(true);
        Main.MasterVolume = 0;
    }
}
