using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 10 * Time.deltaTime, 0);
        if (transform.position.y >= 25)
        {
            transform.Translate(0, -10 * Time.deltaTime, 0);
        }
        else
        {
            transform.Translate(0, 10 * Time.deltaTime, 0);
        }
            
    }
}
