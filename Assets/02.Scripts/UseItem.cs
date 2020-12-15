using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UseItem : MonoBehaviour
{

    MapMove []mapMove ;
    public GameObject playerChracter;
    public Image speed, shield, magnet;
    
    void Start()
    {
        mapMove = GameObject.FindObjectsOfType<MapMove>();
        playerChracter = GameObject.FindWithTag("Player");
        
   
    }

    public void UseSpeedDown()
    {
        for (int i = 0; i < mapMove.Length; i++)
        {
            mapMove[i].moveSpeed = 8;
        }

        speed.gameObject.SetActive(true);

        StartCoroutine(SpeedDownCooltime());
        
    }

    public void UseShield()
    {
        StartCoroutine("Invisivle");

        shield.gameObject.SetActive(true);

        StartCoroutine(ShieldCooltime());
    }



    public void UseMagnet()
    {
        magnet.gameObject.SetActive(true);

        StartCoroutine(MagnetCooltime());
    }

    
    IEnumerator SpeedDownCooltime()
    {
        yield return new WaitForSeconds(60f);
        speed.gameObject.SetActive(false);
      
    }


    IEnumerator ShieldCooltime()
    {
        yield return new WaitForSeconds(30f);
        shield.gameObject.SetActive(false);

    }

    IEnumerator MagnetCooltime()
    {
        yield return new WaitForSeconds(30f);
        magnet.gameObject.SetActive(false);

    }

    IEnumerator Invisivle()
    {
        playerChracter.layer = 10;
        yield return new WaitForSeconds(5.0f);
        playerChracter.layer = 0;

    }// 무적시간
}
