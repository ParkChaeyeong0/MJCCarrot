using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider c)
    { 
        //Is Trigger 체크하기
        if(c.gameObject.name == "Coin")
        {
            Destroy(gameObject);
        }
    }
}
