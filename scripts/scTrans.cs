using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scTrans : MonoBehaviour
{
    public float Speed = 0.5f;

    private float waitTime = 0.1f;
    private float timer = 0.0f;
    private float visualTime = 0.0f;
    private float scrollBar = 1.0f;


    void Start()
    {

    }

    void Awake()
    {

        Time.timeScale = scrollBar;
    }

    void Update()
    {

        timer += Time.deltaTime;

        if (timer > waitTime)
        {
            visualTime = timer;
            timer = timer - waitTime;
            Time.timeScale = scrollBar;
            transform.Translate(Vector3.up * -1 * Time.deltaTime);
        }


    }
}