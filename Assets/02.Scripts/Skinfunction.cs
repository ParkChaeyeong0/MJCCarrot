using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skinfunction : MonoBehaviour
{
    private int randomNumber;

    private float skinRotation = 50.0f;

    public GameObject skinLock0, skinLock1, skinLock2, skinLock3, skinLock4;

    public GameObject skinCharacter0, skinCharacter1;

    void Update()
    {
        transform.Rotate(new Vector3(0, skinRotation * Time.deltaTime, 0));
    }

    public void OnClick_RandomButton()
    {
        randomNumber = Random.Range(0, 5);

        RandomSkinSelect();
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
