using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skinfunction : MonoBehaviour
{
    public List<int> randNum = new List<int>();

    public bool Skin0 = true;
    public bool Skin1 = true;
    public bool Skin2 = true;

    int rand;
    int randRe;

    public static bool selectSkin0= true, selectSkin1 = false, selectSkin2 = false, selectSkin3 = false;

    //캐릭터 회전 속도
    private float skinRotation = 50.0f;

    public GameObject skinLock0, skinLock1, skinLock2;
    public GameObject skinCharacter0, skinCharacter1, skinCharacter2, skinCharacter3, Lock0, Lock1, Lock2;
    public GameObject SuccessGetItemDialog;
    public GameObject FailGetItemDialog;

    [SerializeField]
    private Text TotalScore;

    void Start()
    {
        TotalScore.text = "" + Singleton.getInstance.getTotalCount();
    }

    void Update()
    {
        //캐릭터 회전
        transform.Rotate(new Vector3(0, skinRotation * Time.deltaTime, 0));

    }

    public void OnClick_RandomButton()
    {
       // int rand = Random.Range(0, 3);
        Debug.Log(rand);

        if (randNum.Count >= 3)
        {
            Debug.Log("스킨 모두획득");
        }

        else
        {
            for (; ; )
            {
                if (randNum.Contains(rand))
                {
                    rand = Random.Range(0, 3);
                }

                else
                {
                    break;
                }
            }
        }



        switch (rand)
        {
            case 0:

                int total = Singleton.getInstance.getTotalCount();

                if (total < 50)
                {
                    Debug.Log("코인이 없음");
                    FailGetItemDialog.SetActive(true);
                }

                else if (total >= 50)
                {
                    Singleton.getInstance.minusTotalCount(50);
                    TotalScore.text = "" + Singleton.getInstance.getTotalCount();

                    Skin0 = false;
                    skinLock0.gameObject.SetActive(false);
                    Lock0.SetActive(false);
                    randRe = 0;
                    randNum.Add(0);

                    SuccessGetItemDialog.SetActive(true);
                }

                break;

            case 1:

                Skin1 = false;
                skinLock1.gameObject.SetActive(false);
                Lock1.SetActive(false);
                randRe = 1;
                randNum.Add(1);
                Debug.Log("1");

                break;

            case 2:

                Skin2 = false;
                skinLock2.gameObject.SetActive(false);
                Lock2.SetActive(false);
                randRe = 2;
                randNum.Add(2);
                Debug.Log("2");

                break;
        }
    }

    public void OnClick_GetItemDialogClose()
    {
        FailGetItemDialog.SetActive(false);
        SuccessGetItemDialog.SetActive(false);
    }

    public void OnClick_OneMore()
    {
        int rand = Random.Range(0, 3);
        Debug.Log(rand);


        if (randNum.Contains(rand))
        {
            for (; ; )
            {
                rand = Random.Range(0, 3);
                //if (randNum.Contains(rand) == false)
                //{
                //    continue;
                //}

                if (!randNum.Contains(rand))
                {
                    Debug.Log("중복");
                    break;
                }

                if (randNum.Count > 3)
                {
                    break;
                }
            }

        }

        switch (rand)
        {
            case 0:

                Skin0 = false;
                skinLock0.gameObject.SetActive(false);
                Lock0.SetActive(false);
                randRe = 0;
                randNum.Add(0);
                Debug.Log("0");

                break;

            case 1:

                Skin1 = false;
                skinLock1.gameObject.SetActive(false);
                Lock1.SetActive(false);
                randRe = 1;
                randNum.Add(1);
                Debug.Log("1");

                break;

            case 2:

                Skin2 = false;
                skinLock2.gameObject.SetActive(false);
                Lock2.SetActive(false);
                randRe = 2;
                randNum.Add(2);
                Debug.Log("2");

                break;
        }
    }



    // Skin 선택
    public void OnClick_Skin()
    {
        skinCharacter0.SetActive(true);

        skinCharacter1.SetActive(false);
        skinCharacter2.SetActive(false);
        skinCharacter3.SetActive(false);
        Lock0.SetActive(false);
        Lock1.SetActive(false);
        Lock2.SetActive(false);

        selectSkin0 = true;
        selectSkin1 = false;
        selectSkin2 = false;
        selectSkin3 = false;

    }

    public void OnClick_Skin1()
    {
        skinCharacter1.SetActive(true);


        skinCharacter0.SetActive(false);
        skinCharacter2.SetActive(false);
        skinCharacter3.SetActive(false);
        Lock0.SetActive(false);
        Lock1.SetActive(false);
        Lock2.SetActive(false);

        selectSkin0 = false;
        selectSkin1 = true;
        selectSkin2 = false;
        selectSkin3 = false;
    }

    public void OnClick_Skin2()
    {
        skinCharacter2.SetActive(true);

        skinCharacter0.SetActive(false);
        skinCharacter1.SetActive(false);
        skinCharacter3.SetActive(false);
        Lock0.SetActive(false);
        Lock1.SetActive(false);
        Lock2.SetActive(false);

        selectSkin0 = false;
        selectSkin1 = false;
        selectSkin2 = true;
        selectSkin3 = false;
    }

    public void OnClick_Skin3()
    {
        skinCharacter3.SetActive(true);

        skinCharacter0.SetActive(false);
        skinCharacter1.SetActive(false);
        skinCharacter2.SetActive(false);
        Lock0.SetActive(false);
        Lock1.SetActive(false);
        Lock2.SetActive(false);

        selectSkin0 = false;
        selectSkin1 = false;
        selectSkin2 = false;
        selectSkin3 = true;
    }

    public void OnClick_Lock0()
    {
        Lock0.SetActive(true);

        skinCharacter0.SetActive(false);
        skinCharacter1.SetActive(false);
        skinCharacter2.SetActive(false);
        skinCharacter3.SetActive(false);
        Lock1.SetActive(false);
        Lock2.SetActive(false);
    }

    public void OnClick_Lock1()
    {
        Lock1.SetActive(true);

        skinCharacter0.SetActive(false);
        skinCharacter1.SetActive(false);
        skinCharacter2.SetActive(false);
        skinCharacter3.SetActive(false);
        Lock0.SetActive(false);
        Lock2.SetActive(false);
    }

    public void OnClick_Lock2()
    {
        Lock2.SetActive(true);

        skinCharacter0.SetActive(false);
        skinCharacter1.SetActive(false);
        skinCharacter2.SetActive(false);
        skinCharacter3.SetActive(false);
        Lock0.SetActive(false);
        Lock1.SetActive(false);
    }
}
