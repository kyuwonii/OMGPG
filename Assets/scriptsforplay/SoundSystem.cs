﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    [SerializeField] AudioSource[] bgms = null;
    [SerializeField] AudioSource[] pgMusics = null;

    public AudioSource pgMusic;
    public AudioSource bgm;
    bool songPlayed=false;

    void Start()
    {
        pgMusic=pgMusics[Data.selected_song];
        bgm=bgms[Data.selected_song];
        pgMusic.volume = Data.volumes[0];
        bgm.volume = Data.volumes[1];
        pgMusic.Play(0);
        bgm.Play(0);
    }

    void Update(){
        bgm.timeSamples=pgMusic.timeSamples;
    }
}
