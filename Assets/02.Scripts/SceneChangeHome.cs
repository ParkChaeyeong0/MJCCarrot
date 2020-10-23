using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeHome : MonoBehaviour
{
    public void ChangePlayScene()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void ChangeMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
