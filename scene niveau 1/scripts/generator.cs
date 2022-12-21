using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    float timer = 1;
    public static int sc;
    public static int sc1;
    main main ;
    public GameObject[] gm;
    // Start is called before the first frame update
    void Start()
    {
        sc = 0;
        sc1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            int chance = Random.Range(1, 18);
            float pos_x = Random.Range(-8.0f, 8.0f);
            if (chance <= 2)
            {
                Instantiate(gm[1], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            if (chance == 3 || chance == 4)
            {
                Instantiate(gm[3], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            if (chance == 5 || chance == 6)
            {
                Instantiate(gm[3], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            if (chance == 7 || chance == 8)
            {
                Instantiate(gm[4], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            if (chance == 9 || chance == 10)
            {
                Instantiate(gm[5], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            if (chance == 11 || chance == 12)
            {
                Instantiate(gm[6], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            if (chance == 13 || chance == 14)
            {
                Instantiate(gm[7], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            if (chance == 15 || chance == 16)
            {
                Instantiate(gm[8], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            if (chance > 16)
            {
                Instantiate(gm[0], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            timer = 2.0f;
        }
        print("sc fil geberate : ");print(sc) ;
    }
  
}
