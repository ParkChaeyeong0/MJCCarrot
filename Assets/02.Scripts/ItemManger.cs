using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemManger : MonoBehaviour
{
    GameManager gameManager;
    public Image magnet, shield, slowTime;
    bool magnetSelect = false, shieldSelect = false, timeSelect = false;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (gameManager.magnetSelect)
        {
            this.magnetSelect = true;
            magnet.gameObject.SetActive(false);
        }

        else
        {
            this.magnetSelect = false;
        }

        if (gameManager.shieldSelect)
        {
            this.shieldSelect = true;
            shield.gameObject.SetActive(false);
        }

        else
        {
            this.shieldSelect = false;
        }

        if (gameManager.timeSelect)
        {
            this.timeSelect = true;
            slowTime.gameObject.SetActive(false);
        }
        else
        {
            this.timeSelect = false;
        }

    }


    void Update()
    {
       // ItemSeleted();
    }

    void ItemSeleted() // 선택한 아이템 플레이씬에서 이미지,버튼 활성화
    {
        if (this.magnetSelect)
        {
            //Debug.Log("자석" + gameManager.magnetSelect);
            magnet.gameObject.SetActive(false);
        }

        if (this.shieldSelect)
        {
            //Debug.Log("방패" + gameManager.shieldSelect);
            shield.gameObject.SetActive(false);
        }

        if (this.timeSelect)
        {
            //Debug.Log("시간" + gameManager.timeSelect);
            slowTime.gameObject.SetActive(false);
        }
    }
}
