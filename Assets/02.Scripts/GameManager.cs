using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject settingImg;
    public GameObject producerImg;
    public GameObject ItemDialogImg;
    public GameObject ItemDialogChoiceImg;

    public GameObject SettingButtonSound;
    public GameObject StartButton;
    public GameObject StartButtonSound;
    public GameObject PlayButtonSound;
    public GameObject SkinButtonSound;

    //public Image gameOverImge;

    public bool isEnter = false;

    [SerializeField]
    private Text Score;

    [SerializeField]
    private Text LastEqualsScore;

    void Start()
    {
        LastEqualsScore.text = "" + Singleton.getInstance.getTotalCount();
    }

    // 인게임 코인 표시
    public void viewScore()
    {
        Score.text = "" + Singleton.getInstance.getCount();
    }

    // 씬 이동
    public void OnClick_Start()
    {
        Singleton.getInstance.initCount();

        AudioSource HomeBGM = StartButton.GetComponent<AudioSource>();
        AudioSource EffectSound = StartButtonSound.GetComponent<AudioSource>();

        HomeBGM.Stop();
        EffectSound.Play();

        SceneManager.LoadScene("PlayScene");

    }

    public void OnClick_Skins()
    {
        AudioSource HomeBGM = StartButton.GetComponent<AudioSource>();
        AudioSource skinTouchSound = SkinButtonSound.GetComponent<AudioSource>();

        skinTouchSound.Play();
        HomeBGM.Stop();

        SceneManager.LoadScene("SkinScene");
    }

    public void OnClick_SkinsClose()
    {
        SceneManager.LoadScene("MainScene");
    }

    // 플레이 씬에서 사용
    public void ChangePlayScene()
    {
        //Restart 버튼 눌렀을 시 스코어 다시 카운트
        Time.timeScale = 1f;

        AudioSource RyPlayButtonSound = PlayButtonSound.GetComponent<AudioSource>();
        RyPlayButtonSound.Play();

        SceneManager.LoadSceneAsync("PlayScene");
        OnClick_Start();
    }
    

    public void ChangeMainScene()
    {
        int count = Singleton.getInstance.getCount();
        Singleton.getInstance.sumTotalCount(count);

        AudioSource HomeButtonSound = StartButtonSound.GetComponent<AudioSource>();
        HomeButtonSound.Play();

        SceneManager.LoadScene("MainScene");
    }

    // 아이템 창 띄우고 닫는 버튼
    public void OnClick_ItemDialogOpen()
    {
        AudioSource playTouchSound = PlayButtonSound.GetComponent<AudioSource>();
        playTouchSound.Play();

        ItemDialogImg.SetActive(true);
    }

    public void OnClick_ItemDialogClose()
    {
        ItemDialogImg.SetActive(false);
    }

    //아이템 구매 창 띄우고 닫는 버튼
    public void OnClick_ItemChoiceDialogOpen()
    {
        ItemDialogChoiceImg.SetActive(true);
    }

    public void OnClick_ItemChoiceDialogClose()
    {
        ItemDialogChoiceImg.SetActive(false);
    }

    // 설정 창 띄우고 닫는 버튼
    public void OnClick_SettingButton()
    {
        AudioSource SettingTouchSound = SettingButtonSound.GetComponent<AudioSource>();
        SettingTouchSound.Play();

        settingImg.SetActive(true);
    }

    public void OnClick_SettingButtonClose()
    {
        settingImg.SetActive(false);
    }

    // 제작자 창 띄우고 닫는 버튼
    public void OnClick_ProducerButton()
    {
        AudioSource producerTouchSound = SettingButtonSound.GetComponent<AudioSource>();
        producerTouchSound.Play();

        producerImg.SetActive(true);
    }

    public void OnClick_ProducerClose()
    {
        producerImg.SetActive(false);
    }
}