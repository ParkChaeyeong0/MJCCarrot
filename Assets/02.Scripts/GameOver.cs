using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image gameOverImge;
    
    public bool isEnter = false;

    void Start()
    {
        gameOverImge.gameObject.SetActive(false);
    }

    // 장애물 닿으면 멈추고 게임오버창
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "obs")
        {
            gameOverImge.gameObject.SetActive(true);
            isEnter = true;
        }
    }
}
