using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_moulin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // ...also rotate around the World's Y axis
        transform.Rotate(0, 0, Time.deltaTime, Space.World);
    }
}
