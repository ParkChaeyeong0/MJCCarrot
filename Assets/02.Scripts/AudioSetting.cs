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

    private float backVol = 1f;

    private void Start()
    {
        DontDestroyOnLoad(transform.gameObject);

        backVol = PlayerPrefs.GetFloat("backvol", 1f);
        audioSlider.value = backVol;
        audio.volume = audioSlider.value;

        //플레이어 캐릭터의 사망 이벤트 발생 시 사망 BGM 재생 메소드 실행
        // += GameStart;
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
