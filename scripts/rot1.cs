using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot1 : MonoBehaviour
{
    public int A = 1;
    public float speed = 2.0f;
    public float rotationSpeed = 100.0f;
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Fleches1();
    }
    void Fleches1()
    {

        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float translation1 = Input.GetAxis("Horizontal") * speed;
        //float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        translation1 *= Time.deltaTime;

        //rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, translation, 0);

        // Rotate around our y-axis
        //transform.Rotate(0, rotation, 0);
        // Move translation along the object's z-axis
        transform.Translate(translation1, 0, 0);
    }

}
