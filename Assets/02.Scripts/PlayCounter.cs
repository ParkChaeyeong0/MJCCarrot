﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayCounter : MonoBehaviour
{
    private int Timer = 0;

    public Text Num_A;   //1번
    public Text Num_B;   //2번
    public Text Num_C;   //3번
    public Text Num_GO;



    void Start()

    {

        Setting();



    }



    void Update()
    {

        Go();

    }

    public void Setting()
    {
        //시작시 카운트 다운 초기화
        Timer = 0;



        Num_A.gameObject.SetActive(false);
        Num_B.gameObject.SetActive(false);
        Num_C.gameObject.SetActive(false);
        Num_GO.gameObject.SetActive(false);
    }

    public void Go(){
        //게임 시작시 정지
        if (Timer == 0)
        {
            Time.timeScale = 0.0f;
        }


        //Timer 가 90보다 작거나 같을경우 Timer 계속증가

        if (Timer <= 180)
        {
            Timer++;

            // Timer가 30보다 작을경우 3번켜기
            if (Timer < 60)
            {
                Num_C.gameObject.SetActive(true);
            }

            // Timer가 30보다 클경우 3번끄고 2번켜기
            if (Timer > 60)
            {
                Num_C.gameObject.SetActive(false);
                Num_B.gameObject.SetActive(true);
            }

            // Timer가 60보다 작을경우 2번끄고 1번켜기
            if (Timer > 120)
            {
                Num_B.gameObject.SetActive(false);
                Num_A.gameObject.SetActive(true);
            }

            //Timer 가 90보다 크거나 같을경우 1번끄고 GO 켜기 LoadingEnd () 코루틴호출
            if (Timer >= 180)
            {
                Num_A.gameObject.SetActive(false);
                Num_GO.gameObject.SetActive(true);
                StartCoroutine(this.LoadingEnd());
                Time.timeScale = 1.0f; //게임시작
            }
        }

    }


    IEnumerator LoadingEnd()
    {


        yield return new WaitForSeconds(1.0f);
        Num_GO.gameObject.SetActive(false);
    }
}
