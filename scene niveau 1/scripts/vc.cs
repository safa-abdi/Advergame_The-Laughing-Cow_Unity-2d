using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vc : MonoBehaviour
{
    Transform tr ;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }
    void Update()
    {
        if(Input.GetKey("right")== true)
        {
            if (tr.position.x < 8f) tr.position += new Vector3(0.2f, 0f, 0f);
        }
        if (Input.GetKey("left") == true)
        {
            if (tr.position.x > -8f) tr.position += new Vector3(-0.2f, 0f, 0f);
        }
    }
    // Update is called once per frame

}
