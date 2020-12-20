using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySkinSelect : MonoBehaviour
{
    public GameObject Skin0, Skin1, Skin2, Skin3;

    public void SkinSelect()
    {

        if (Skinfunction.selectSkin0 == true)
        {
            Skin0.SetActive(true);
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);

            Debug.Log("0나옴");
        }

        else if (Skinfunction.selectSkin1 == true)
        {
            Skin0.SetActive(false);
            Skin1.SetActive(true);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Debug.Log("1나옴");
        }

        else if(Skinfunction.selectSkin2 == true)
        {
            Skin0.SetActive(false);
            Skin1.SetActive(false);
            Skin2.SetActive(true);
            Skin3.SetActive(false);
            Debug.Log("2나옴");
        }

        else if(Skinfunction.selectSkin3 == true)
        {
            Skin0.SetActive(false);
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(true);
            Debug.Log("3나옴");
        }
    }
}
