using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skinfunction : MonoBehaviour
{
    public List<int> randomNumber = new List<int>() { 0, 1, 2};

    public bool Skin0 = true;
    public bool Skin1 = true;
    public bool Skin2 = true;

    //캐릭터 회전 속도
    private float skinRotation = 50.0f;

    public GameObject failImage;
    public GameObject skinLock0, skinLock1, skinLock2;
    public GameObject skinCharacter0, skinCharacter1, skinCharacter2, skinCharacter3, Lock0, Lock1, Lock2;

    void Update()
    {
        //캐릭터 회전
        transform.Rotate(new Vector3(0, skinRotation * Time.deltaTime, 0));
    }

    public void OnClick_Close()
    {
        failImage.SetActive(false);
    }

    public void OnClick_RandomButton()
    {
        int rand = Random.Range(0, randomNumber.Count);

        switch (rand)
        {
            case 0:

                Skin0 = false;
                skinLock0.gameObject.SetActive(false);
                Lock0.SetActive(false);

                Debug.Log("0");

                break;

            case 1:

                Skin1 = false;
                skinLock1.gameObject.SetActive(false);
                Lock1.SetActive(false);

                Debug.Log("1");

                break;

            case 2:

                Skin2 = false;
                skinLock2.gameObject.SetActive(false);
                Lock2.SetActive(false);

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
        Lock2.SetActive(false);
    }
}
