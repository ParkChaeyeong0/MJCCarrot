using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Item
{
    timeSave, magnet, shield
}

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public Item currentitem;
}
