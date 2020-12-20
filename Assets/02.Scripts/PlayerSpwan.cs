using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpwan : MonoBehaviour
{
    public Transform playerTs;
    public GameObject[] playerCharacter;


    public GameObject BGMStop;
    public GameObject GameOverSound;

    void Start()
    {
        PlayerSpwanPoint();
    }

    void Update()
    {
       
    }
   
    void PlayerSpwanPoint()
    {
        if (!GameOver.isEnter)
        {
            AudioSource BGMSound = BGMStop.GetComponent<AudioSource>();

            BGMSound.Play();
        }
        else
        {
            AudioSource BGMSound = BGMStop.GetComponent<AudioSource>();

            BGMSound.Stop();
        }

        if (Skinfunction.selectSkin0)
        {
            Instantiate(playerCharacter[0], transform.position, transform.rotation);
         
        }

        if (Skinfunction.selectSkin1)
        {
            Instantiate(playerCharacter[1], transform.position, transform.rotation);
        }

        if (Skinfunction.selectSkin2)
        {
            Instantiate(playerCharacter[2], transform.position, transform.rotation);
        }

        if (Skinfunction.selectSkin3)
        {
            Instantiate(playerCharacter[3], transform.position, transform.rotation);
        }
    }

}
