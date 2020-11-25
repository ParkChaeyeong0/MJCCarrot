using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItem : MonoBehaviour
{
    public Item item;   

    void Start()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        DataManager.instance.currentitem = item;
    }
}
