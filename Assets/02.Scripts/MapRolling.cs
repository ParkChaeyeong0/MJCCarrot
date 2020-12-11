using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRolling : MonoBehaviour
{
    Transform trans;
    Vector3 nowPos;
    SpwanObsAndCoin spwanObsAndCoin = new SpwanObsAndCoin();

    void Awake()
    {
        nowPos = this.gameObject.transform.position;
     
    }

    void Start()
    {
        
        trans = GetComponent<Transform>();
    
      
    }

    // Update is called once per frame
    void Update()
    {

        if (trans.position.z < -260)
        {
            trans.position = new Vector3(nowPos.x,nowPos.y,104.3f);
          
        }
    }
}
