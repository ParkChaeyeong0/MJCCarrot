using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerMove : MonoBehaviour
{
    public float moveSpeed;
    Transform tr;
    void Start()
    {
        tr = GetComponent<Transform>();
    }

   
    void Update()
    {
        if (Input.GetKey("left"))
        {
            tr.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("right"))
        {
            tr.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
}
