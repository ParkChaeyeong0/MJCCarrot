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
        nowPos = this.gameObject.transform.localPosition;
     
    }

    void Start()
    {
        
        trans = GetComponent<Transform>();
    
      
    }

    // Update is called once per frame
    void Update()
    {

        if (trans.localPosition.z < -346.7)
        {
            trans.localPosition = new Vector3(nowPos.x,nowPos.y, 195.3f);
          
        }
    }
}
