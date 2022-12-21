using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piecesPuzz : MonoBehaviour
{
    private Vector3 rightPos;
     public bool  InRightPos;
      public bool selectedd;
    // Start is called before the first frame update
    void Start()
    {
         rightPos= transform.position;
         transform.position=new Vector3 (Random.Range(4f,8f),Random.Range(0.75f,-3f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position,rightPos)<0.5)
        {
            if(!selectedd)
            {
            transform.position=rightPos;
            InRightPos=true;
            }
        }
    }
}
