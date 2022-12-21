using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingredients : MonoBehaviour
{
    main main;
    Transform tr;
    public int val;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        main = GameObject.Find("scripts").GetComponent<main>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.position -= new Vector3(0f, 0.009f, 0f);
        if (tr.position.y < -7f) Destroy(this.gameObject);
    }

    void SoundOn(Vector3 itemPos)
    {
        Transform obj = Instantiate(main.collectedSound, itemPos, new Quaternion());
        obj.gameObject.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "car body")
        {
            SoundOn(collision.transform.position);
            main.ScoreAdd(val);
            Destroy(this.gameObject);
        }
        if(main.score >= 1500)
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            main.gain = true;
        }
    }
}
