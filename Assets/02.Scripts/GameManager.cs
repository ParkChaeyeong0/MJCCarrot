using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject settingImg;

    public void OnClick_Start()
    {
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

    public void OnClick_SettingButton()
    {
        settingImg.SetActive(true);
    }

    public void OnClick_SettingButtonClose()
    {
        settingImg.SetActive(false);
    }
}
