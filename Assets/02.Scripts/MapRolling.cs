using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRolling : MonoBehaviour
{
    Transform trans;
    Transform nowPos;

    void Awake()
    {
        nowPos = GetComponent<Transform>();
    }

    void Start()
    {
        
        trans = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(nowPos.position);


        if (trans.position.z < -123.5)
        {
            trans.position = new Vector3(0,0,0);
        }
    }
}
