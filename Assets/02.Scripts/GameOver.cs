using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image gameOverImge;

    //public GameObject BGMStop;
    public GameObject GameOverSound;
    public AudioSource BGMStop;

    public static bool isEnter = false;

    void Start()
    {
        gameOverImge = GameObject.FindGameObjectWithTag("GameOverView").GetComponent<Image>();
        gameOverImge.gameObject.SetActive(false);
        BGMStop = GameObject.FindGameObjectWithTag("Manager").GetComponent<AudioSource>();


    }

    // 장애물 닿으면 멈추고 게임오버창
    private void OnTriggerEnter(Collider col)
    {

        if (col.tag == "obs")
        {
            gameOverImge.gameObject.SetActive(true);

            isEnter = true;

            AudioSource BGMSound = BGMStop.GetComponent<AudioSource>();
            AudioSource GameOver = GameOverSound.GetComponent<AudioSource>();

            GameOver.Play();
            BGMSound.Stop();
        }
    }
}
