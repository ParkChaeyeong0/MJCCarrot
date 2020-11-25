using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlyerMove : MonoBehaviour
{
    public float Speed = 0.25f;

    private Vector2 nowPos, prePos;
    private Vector3 movePos;

    GameOver isOver;
    GameManager gameManager;

    public GameObject CoinGetSoundEffect;

    void Start()
    {
        isOver = GameObject.Find("Player").GetComponent<GameOver>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
                prePos = touch.position + touch.deltaPosition;
            }
        } //플레이어 x축 드래그터치 이동
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            //Singleton에서 increaseCount 클래스 가져옴.
            Singleton.getInstance.increaseCount();

            //GameManager에서 viewSore클래스 가져옴.
            gameManager.viewScore();

            other.gameObject.SetActive(false);

            // 효과음
            AudioSource CoinGetSound = CoinGetSoundEffect.GetComponent<AudioSource>();

            CoinGetSound.Play();
        }
    }
}
