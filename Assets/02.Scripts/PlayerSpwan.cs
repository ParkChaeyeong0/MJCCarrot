using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpwan : MonoBehaviour
{
    public Transform playerTs;
    public GameObject[] playerCharacter;
    
    void Start()
    {
        PlayerSpwanPoint();
    }

   
    void PlayerSpwanPoint()
    {
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
