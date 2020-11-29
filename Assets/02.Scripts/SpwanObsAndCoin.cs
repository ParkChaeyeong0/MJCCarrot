using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanObsAndCoin : MonoBehaviour
{
    public GameObject obs, coin, item;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
     
        
    }

    public void Spot()
    {
        //int random = Random.Range(0, 3);
        int random = Random.Range(0, 2);
        if (random == 0)
        {
            obs.transform.position = transform.position;
        }

        else if (random == 1)
        {
            coin.transform.position = transform.position;
        }
        Debug.Log(random);
        //else 
        //{

        //}
    }
}
