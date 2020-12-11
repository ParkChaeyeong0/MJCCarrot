using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounManger : MonoBehaviour
{
    GameOver gameOver;

    
    public GameObject BGMStop;
    public GameObject GameOverSound;

    void Start()
    {
        gameOver = GameObject.Find("Player").GetComponent<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameOver.isEnter);

        if (gameOver.isEnter)
        {
            AudioSource BGMSound = BGMStop.GetComponent<AudioSource>();
            AudioSource GameOver = GameOverSound.GetComponent<AudioSource>();

            GameOver.Play();
            BGMSound.Stop();
        }
    }
}
