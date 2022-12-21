using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Non_Ingredients : MonoBehaviour
{
    public Text scoreB;
    main main;
    Transform tr;
    
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        main = GameObject.Find("scripts").GetComponent<main>();
    }
    void SoundOn(Vector3 itemPos)
    {
        Transform obj = Instantiate(main.NoncollectedSound, itemPos, new Quaternion());
        obj.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        tr.position -= new Vector3(0f, 0.009f, 0f);
        if (tr.position.y < -7f) Destroy(this.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "car body")
        {
            SoundOn(collision.transform.position);
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            main.GameOver = true;
        }
    }
}
