using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{

    MapMove []mapMove ;
 
    
    void Start()
    {
        mapMove = GameObject.FindObjectsOfType<MapMove>();
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

    }

    public void UseMagnet()
    {

    }

}
