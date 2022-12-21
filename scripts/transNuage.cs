using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transNuage : MonoBehaviour
{

    public float delta = 10.5f;  // Amount to move left and right from the start point
    public float speed = 15.0f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed )*10;
        transform.position = v;
    }

}