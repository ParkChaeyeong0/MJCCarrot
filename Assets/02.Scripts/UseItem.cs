using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{

    MapMove []mapMove ;
    public GameObject playerChracter;

    
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
        
    }

    public void UseShield()
    {
        StartCoroutine("Invisivle");
    }

    IEnumerator Invisivle()
    {
        playerChracter.layer = 10;
        yield return new WaitForSeconds(5.0f);
        playerChracter.layer = 0;
        
    }

    public void UseMagnet()
    {

    }

    

}
