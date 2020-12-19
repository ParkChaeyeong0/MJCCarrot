using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinObsSpwan : MonoBehaviour
{
    public Transform[] spwanPos;
    public GameObject[] obsCoin;
    int obsCoinRand;
    public GameObject map;
    GameObject child;
 

    void Start()
    {
  
     
        this.transform.parent = map.transform;




        Spwan();
    }

    void Update()
    {
       

  
        
    }

    public void Spwan()
    {
        obsCoinRand = Random.Range(0, obsCoin.Length);
        switch (obsCoinRand)
        {
            case 0:
                    child = Instantiate(obsCoin[0], transform.position, transform.rotation);               
                    child.transform.parent = this.transform;
                    break;

            case 1:
                    child = Instantiate(obsCoin[1], transform.position, transform.rotation);              
                    child.transform.parent = this.transform;
                    break;

            case 2:
                    child = Instantiate(obsCoin[2], transform.position, transform.rotation); 
                    child.transform.parent = this.transform;
                    break;

            case 3:
                    child = Instantiate(obsCoin[3], transform.position, transform.rotation);           
                    child.transform.parent = this.transform;
                    break;

            case 4:
                    child = Instantiate(obsCoin[4], transform.position, transform.rotation);
                    child.transform.parent = this.transform;
                    break;

            default:
                child = Instantiate(obsCoin[0], transform.position, transform.rotation);
                child.transform.parent = this.transform;
                break;
        }
    }
}
