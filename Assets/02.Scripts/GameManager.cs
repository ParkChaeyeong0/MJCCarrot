using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject settingImg;

    //public Image gameOverImge;

    public bool isEnter = false;

    [SerializeField]
    private Text Score;

    [SerializeField]
    private Text LastEqualsScore;

    void Start()
    {
        LastEqualsScore.text = "Score : " + Singleton.getInstance.getTotalCount();
    }

    // 인게임 코인 표시
    public void viewScore()
    {
        Score.text = "Score : " + Singleton.getInstance.getCount();
    }

    // 씬 이동
    public void OnClick_Start()
    {
        Singleton.getInstance.initCount();
        SceneManager.LoadScene("PlayScene");
    }

    public void OnClick_Skins()
    {
        SceneManager.LoadScene("SkinScene");
    }

    public void OnClick_SkinsClose()
    {
        SceneManager.LoadScene("MainScene");
    }

    // 플레이 씬에서 사용
    public void ChangePlayScene()
    {   
        SceneManager.LoadScene("PlayScene");
    }

    public void ChangeMainScene()
    {
        int count = Singleton.getInstance.getCount();
        Singleton.getInstance.sumTotalCount(count);
        SceneManager.LoadScene("MainScene");
    }

    // 설정 창 띄우고 닫는 버튼
    public void OnClick_SettingButton()
    {
        settingImg.SetActive(true);
    }

    public void OnClick_SettingButtonClose()
    {
        settingImg.SetActive(false);
    }

    // 화면 비율 고정
    public void setupCamera()
    {
        //가로 화면 비율
        float targetWidthAspect = 16.0f;

        //세로 화면 비율
        float targetHeightAspect = 10.0f;

        //메인 카메라
        Camera mainCamera = Camera.main;

        mainCamera.aspect = targetWidthAspect / targetHeightAspect;

        float widthRatio = (float)Screen.width / targetWidthAspect;
        float heightRatio = (float)Screen.height / targetHeightAspect;

        float heightadd = ((widthRatio / (heightRatio / 100)) - 100) / 200;
        float widthtadd = ((heightRatio / (widthRatio / 100)) - 100) / 200;

        // 16_10비율보다 가로가 짧다면 (4_3비율)
        // 16_10비율보다 세로가 짧다면 (16_9비율)
        // 시작 지점을 0으로 만들어준다.

        if (heightRatio > widthRatio)
        {
            widthtadd = 0.0f;
        }
        else
            heightadd = 0.0f;

        mainCamera.rect = new Rect(
            mainCamera.rect.x + Math.Abs(widthtadd),
            mainCamera.rect.y + Math.Abs(heightadd),
            mainCamera.rect.width + (widthtadd * 2),
            mainCamera.rect.height + (heightadd * 2));
    }
}
