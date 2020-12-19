using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRolling : MonoBehaviour
{
    Transform trans;
    Vector3 nowPos;
    CoinObsSpwan []coinObsSpwan;
    public GameObject[] coin;
    public GameObject[] obs;
 

    void Awake()
    {
        nowPos = this.gameObject.transform.localPosition;
       
      
    }

    void Start()
    {
        coinObsSpwan = GameObject.FindObjectsOfType<CoinObsSpwan>();
        trans = GetComponent<Transform>();
    
    }

    // Update is called once per frame
    void Update()
    {


        if (trans.localPosition.z < -346.7)
        {



            coin = GameObject.FindGameObjectsWithTag("Coin");
            obs = GameObject.FindGameObjectsWithTag("obs");

            trans.localPosition = new Vector3(nowPos.x,nowPos.y, 195.3f);

            for (int i = 0; i < coin.Length; i++)
            {
                Destroy(coin[i]);
            }

            for (int i = 0; i < obs.Length; i++)
            {
                Destroy(obs[i]);
            }

            for (int i = 0; i < coinObsSpwan.Length; i++)
            {
                coinObsSpwan[i].Spwan();
            }

           
        }
    }
}
