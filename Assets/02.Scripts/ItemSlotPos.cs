using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlotPos : MonoBehaviour
{
    public GameObject[] charPrefebs;
    public GameObject item;

    void Start()
    {
        
        item = Instantiate(charPrefebs[(int)DataManager.instance.currentitem]);
        item.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
