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
    public GameObject ItemDialogChoiceImg1;
    public GameObject ItemDialogChoiceImg2;
    public GameObject SuccessGetItemDialog;
    public GameObject FailGetItemDialog;


    public GameObject BGMStop;
    public GameObject GameOverSound;

    public GameObject SettingButtonSound;
    public GameObject StartButton;
    public GameObject StartButtonSound;
    public GameObject PlayButtonSound;
    public GameObject SkinButtonSound;

    public static bool isEnter = false;
    public static bool magnetSelect = false;
    public static bool timeSelect = false;
    public static bool shieldSelect = false;

    [SerializeField]
    private Text Score;

    [SerializeField]
    private Text TotalScore;

    [SerializeField]
    private Text BestScore;


    void Start()
    {
        Singleton.getInstance.setTotalCount(PlayerPrefs.GetInt("COIN", 0));
        TotalScore.text = "" + PlayerPrefs.GetInt("COIN", Singleton.getInstance.getTotalCount());
        BestScore.text = "Best Score : " + PlayerPrefs.GetInt("BestScore", 0).ToString();
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
        int count = Singleton.getInstance.getCount();
        Singleton.getInstance.sumTotalCount(count);
        Singleton.getInstance.saveCoins(); // 현재 코인 저장
        GameOver.isEnter = false;

        //Restart 버튼 눌렀을 시 스코어 다시 카운트
        Singleton.getInstance.initCount();
        Time.timeScale = 1f;

        AudioSource RyPlayButtonSound = PlayButtonSound.GetComponent<AudioSource>();
        RyPlayButtonSound.Play();

        SceneManager.LoadSceneAsync("PlayScene");
    }
    

    public void ChangeMainScene()
    {
        int count = Singleton.getInstance.getCount();
        Singleton.getInstance.sumTotalCount(count);
        Singleton.getInstance.saveCoins(); // 현재 코인 저장

        AudioSource HomeButtonSound = StartButtonSound.GetComponent<AudioSource>();
        HomeButtonSound.Play();

        SceneManager.LoadScene("MainScene");

        magnetSelect = false;
        shieldSelect = false;
        timeSelect = false; // 2020.12.12 홈버튼 누르면 아이템 선택안함상태로 초기화
        GameOver.isEnter = false;
        
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

    public void OnClick_ItemChoiceDialogOpen1()
    {
        ItemDialogChoiceImg1.SetActive(true);
    }

    public void OnClick_ItemChoiceDialogOpen2()
    {
        ItemDialogChoiceImg2.SetActive(true);
    }

    public void OnClick_magnetChoiceDialogClose()
    {
        int total = Singleton.getInstance.getTotalCount();

        if (total < 5)
        {
            Debug.Log("코인이 없음");
            FailGetItemDialog.SetActive(true);
        }

        else if (total >= 5)
        {
            magnetSelect = true;

            Singleton.getInstance.minusTotalCount(5);
            TotalScore.text = "" + Singleton.getInstance.getTotalCount();

            SuccessGetItemDialog.SetActive(true);
        }

        ItemDialogChoiceImg.SetActive(false);
    }

    public void OnClick_TimeChoiceDialogClose()
    {
        int total = Singleton.getInstance.getTotalCount();

        if (total < 5)
        {
            Debug.Log("코인이 없음");
            FailGetItemDialog.SetActive(true);
        }

        else if (total >= 5)
        {
            timeSelect = true;

            Singleton.getInstance.minusTotalCount(5);
            TotalScore.text = "" + Singleton.getInstance.getTotalCount();

            SuccessGetItemDialog.SetActive(true);
        }

        ItemDialogChoiceImg1.SetActive(false);
    }

    public void OnClick_shieldChoiceDialogClose()
    {
        int total = Singleton.getInstance.getTotalCount();

        if (total < 5)
        {
            Debug.Log("코인이 없음");
            FailGetItemDialog.SetActive(true);
        }

        else if(total >= 5)
        {
            shieldSelect = true;

            Singleton.getInstance.minusTotalCount(5);
            TotalScore.text = "" + Singleton.getInstance.getTotalCount();

            SuccessGetItemDialog.SetActive(true);
        }

        ItemDialogChoiceImg2.SetActive(false);
    }

    public void OnClick_ItemChoiceDialogClose()
    {
        ItemDialogChoiceImg.SetActive(false);
        ItemDialogChoiceImg1.SetActive(false);
        ItemDialogChoiceImg2.SetActive(false);
    }

    public void OnClick_GetItemDialogClose()
    {
        FailGetItemDialog.SetActive(false);
        SuccessGetItemDialog.SetActive(false);
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

    /*private void OnTriggerEnter(Collider col)
    {

        if (col.tag == "obs")
        {

            AudioSource BGMSound = BGMStop.GetComponent<AudioSource>();
            AudioSource GameOver = GameOverSound.GetComponent<AudioSource>();

            GameOver.Play();
            BGMSound.Stop();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            // 효과음
            AudioSource CoinGetSound = CoinGetSoundEffect.GetComponent<AudioSource>();

            CoinGetSound.Play();
        }
    }*/
}