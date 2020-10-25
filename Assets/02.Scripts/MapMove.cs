using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class MapMove : MonoBehaviour
{
    public float moveSpeed;
    Transform tr;
    GameOver isOver;
    void Start()
    {
        tr = GetComponent<Transform>();
        isOver = GameObject.Find("Player").GetComponent<GameOver>();
    }

  
    void Update()
    {
        if (!isOver.isEnter)
        {
            Move();
        }
       
    }
    void Move()
    {
        tr.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    } // 맵이동
}
