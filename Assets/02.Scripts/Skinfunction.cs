using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skinfunction : MonoBehaviour
{
    private int randomNumber;

    //캐릭터 회전 속도
    private float skinRotation = 50.0f;

    public GameObject skinLock0, skinLock1, skinLock2, skinLock3, skinLock4;

    public GameObject skinCharacter0, skinCharacter1;

    void Update()
    {
        //캐릭터 회전
        transform.Rotate(new Vector3(0, skinRotation * Time.deltaTime, 0));
    }

    public void OnClick_RandomButton()
    {
        randomNumber = Random.Range(0, 5);

        RandomSkinSelect();
    }

    public int[] GetRandomInt(int length, int min, int max)
    {
        int[] randArray = new int[length];
        bool isSame;

        for (int i = 0; i<length; ++i)
        {
            while (true)
            {
                randArray[i] = Random.Range(min, max);
                isSame = false;

                for(int j=0; j<i; ++j)
                {
                    if(randArray[j] == randArray[i])
                    {
                        isSame = true;
                        break;
                    }
                }

                if (!isSame) break;
            }
        }
        return randArray;
    }

    // Random버튼 선택
    private void RandomSkinSelect()
    {
        switch (randomNumber)
        {
            case 0:

                skinLock0.gameObject.SetActive(false);

                break;

            case 1:

                skinLock1.gameObject.SetActive(false);

                break;

            case 2:

                skinLock2.gameObject.SetActive(false);

                break;

            case 3:

                skinLock3.gameObject.SetActive(false);

                break;

            case 4:

                skinLock4.gameObject.SetActive(false);

                break;
        }
    }

    // Skin 선택
    public void OnClick_Skin()
    {
        Debug.Log("skin0");

        skinCharacter1.SetActive(false);
        skinCharacter0.SetActive(true);
    }

    public void OnClick_Skin1()
    {
        skinCharacter0.SetActive(false);
        skinCharacter1.SetActive(true);
    }
}
