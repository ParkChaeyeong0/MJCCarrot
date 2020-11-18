using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSetting : MonoBehaviour
{
    //public AudioMixer masterMixer;
    public Slider audioSlider;
    public AudioSource audio;

    private float backVol = 1f;

    private void Start()
    {
        backVol = PlayerPrefs.GetFloat("backvol", 1f);
        audioSlider.value = backVol;
        audio.volume = audioSlider.value;
    }

    void Update()
    {
        SoundSlider();
    }

    public void SoundSlider()
    {
        audio.volume = audioSlider.value;

        backVol = audioSlider.value;
        PlayerPrefs.SetFloat("backvol", backVol);
    }
}
