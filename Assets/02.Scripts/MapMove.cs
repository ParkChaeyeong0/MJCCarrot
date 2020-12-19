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
     //   isOver = GameObject.FindGameObjectWithTag("Player").GetComponent<GameOver>();
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
        //if (moveSpeed >= 50)
        //{
        //    moveSpeed = moveSpeed + Time.fixedDeltaTime + 1;
        //}   갈수록 빨라지는 속도 조정 가능
    }
}
