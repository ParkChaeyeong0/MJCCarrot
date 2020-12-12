using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
    public void OnClick_Button() {
    }

    public int[] getRandomInt(int length, int min, int max)
    {

        int[] randArray = new int[length];
        bool isSame;

        for (int i = 0; i < length; ++i)
        {
            while (true)
            {
                randArray[i] = Random.Range(min, max);
                isSame = false;

                Debug.Log("while문");

                for (int j = 0; j < i; ++j)
                {
                    isSame = true;
                    Debug.Log("while문 안의 for문");
                    break;
                }

                if (!isSame) break;
            }
        }
        return randArray;
    }

    /*public List<string> GachList = new List<string>() { "치킨", "피자", "햄버거" };

    public void Gacha()
    {
        int rand = Random.Range(0, GachList.Count);
        print(GachList[rand]);
        GachList.RemoveAt(rand);
    }*/
}
