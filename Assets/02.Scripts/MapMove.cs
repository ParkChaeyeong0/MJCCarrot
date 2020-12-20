using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class MapMove : MonoBehaviour
{
    public float moveSpeed;

    Transform tr;
   
    void Start()
    {
        tr = GetComponent<Transform>();
 
    }

  
    void Update()
    {
        Debug.Log(GameOver.isEnter);
        if (!GameOver.isEnter)
        {
            Move();
        }
       
    }

    // 맵이동
    public void Move()
    {
        tr.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        moveSpeed += Time.fixedDeltaTime;
   
    }
}
