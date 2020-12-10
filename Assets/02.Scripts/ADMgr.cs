using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;
using System.Collections.Generic;

public class ADMgr : MonoBehaviour
{
    public void ShowAD()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}