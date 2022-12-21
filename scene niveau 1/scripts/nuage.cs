using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuage : MonoBehaviour
{
    int _transSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_transSpeed * Time.deltaTime, 0, 0);

    }
}
