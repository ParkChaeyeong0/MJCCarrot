using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerMove : MonoBehaviour
{
    public float Speed = 0.25f;
    private Vector2 nowPos, prePos;
    private Vector3 movePos;
    GameOver isOver;

    void Start() {
        isOver = GameObject.Find("Player").GetComponent<GameOver>();

    }

    void Update()
    {
        if (!isOver.isEnter)
        {
            move();
        }
        

    }
    void move()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                prePos = touch.position - touch.deltaPosition;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                nowPos = touch.position - touch.deltaPosition;
                movePos = (Vector3)(prePos - nowPos) * Time.deltaTime * Speed;
                movePos.y = 0;
                movePos.z = 0;
                gameObject.transform.Translate(movePos);
                prePos = touch.position - touch.deltaPosition;
            }
        } //플레이어 x축 드래그터치 이동
    }
}
