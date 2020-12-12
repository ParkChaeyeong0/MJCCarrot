using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSetting : MonoBehaviour
{
    // 볼륨 조절

    //public AudioMixer masterMixer;
    public Slider audioSlider;
    public AudioSource audio;

    private float bGM = 1f;

    private void Start()
    {
        DontDestroyOnLoad(transform.gameObject);

        bGM = PlayerPrefs.GetFloat("backvol", 1f);
        audioSlider.value = bGM;
        audio.volume = audioSlider.value;
    }

    void Update()
    {
        SoundSlider();
    }

    public void SoundSlider()
    {
        audio.volume = audioSlider.value;

        bGM = audioSlider.value;
        PlayerPrefs.SetFloat("backvol", bGM);
    }

}
