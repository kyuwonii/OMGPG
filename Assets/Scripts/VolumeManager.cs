﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    [SerializeField] Slider PGSlider = null;
    [SerializeField] Slider BGSlider = null;
    [SerializeField] Slider BTNSlider = null;
    
    // Start is called before the first frame update
    void Start()
    {
        PGSlider.value = Data.volumes[0];
        BGSlider.value = Data.volumes[1];
        BTNSlider.value = Data.volumes[2];
    }

    public void SetPGVolume()
    {
        Data.volumes[0] = PGSlider.value;
    }

    public void TestPGVolume(){
        SoundEffect.buttonAudio.volume = PGSlider.value;;
        SoundEffect.buttonAudio.Play();
        SoundEffect.buttonAudio.volume = BTNSlider.value;
    }

    public void SetBackgroundVolume()
    {
        Data.volumes[1] = BGSlider.value;
    }

    public void TestBGVolume(){
        SoundEffect.buttonAudio.volume = BGSlider.value;
        SoundEffect.buttonAudio.Play();
        SoundEffect.buttonAudio.volume = BTNSlider.value;
    }

    public void SetButtonVolume()
    {
        Data.volumes[2] = BTNSlider.value;
    }

    public void TestBTNVolume(){
        SoundEffect.buttonAudio.Play();
    }
}