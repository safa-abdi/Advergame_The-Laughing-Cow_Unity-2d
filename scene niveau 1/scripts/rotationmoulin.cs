using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationmoulin : MonoBehaviour
{
    public float angle = 2f;
    public float rotationSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        angle += rotationSpeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0.0f, 0.0f, angle);
    }
}
