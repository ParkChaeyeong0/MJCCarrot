using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;

    int count = 0;

    public Text Score;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Score.text = "Score: " + count;
                                //count.ToString();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        //"Coin"태그 오브젝트와 충돌 시 Score +1
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            Score.text = "Score: " + count;
                                    //count.ToString();
        }
    }
}