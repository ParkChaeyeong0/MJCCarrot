using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlyerMove : MonoBehaviour
{
    // 좌우 이동 속도
    public float Speed = 0.25f;

    private Vector2 nowPos, prePos;
    private Vector3 movePos;

    private int score = 0;

    public Text Score;

    GameOver isOver;

    void Start()
    {
        isOver = GameObject.Find("Player").GetComponent<GameOver>();
        Score.text = "Score : " + score;
    }

    void Update()
    {
        if (!isOver.isEnter)
        {
            move();
        }
    }

    // 플레이어 x축 드래그 터치 이동
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
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // 만약 코인이 닿으면
        if (other.gameObject.CompareTag("Coin"))
        {
            //GmaeMaanger에서 Coin 클래스 가져옴.
            //GameManager.Instance.Coin();

            other.gameObject.SetActive(false);


            score = score + 1;
            Score.text = "Score : " + score;
        }
    }
}
