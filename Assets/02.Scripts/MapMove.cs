using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float moveSpeed;
    Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

  
    void Update()
    {
        tr.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }
}
