using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tourne : MonoBehaviour
{
    public float xSpeed = 0f;
    public float ySpeed = 0f;
    public float zSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(
               0,
               0,
               zSpeed * Time.deltaTime
          );
    }
}

