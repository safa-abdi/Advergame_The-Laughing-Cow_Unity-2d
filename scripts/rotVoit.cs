using UnityEngine;

public class rotVoit : MonoBehaviour
{

    public float speed = 0f;
    public float rotationSpeed = 0f;
    public Transform player;
    public Sprite straight;
    public Sprite leftTurn;
    public Sprite rightTurn;

    void FixedUpdate()
    {
        // Holding down W key to speed up
        if (Input.GetKey("w"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = straight;
            if (speed < .04f)
            {
                speed = speed + .005f;
                player.transform.Translate(0, speed, 0);
            }
            else
            {
                speed = .04f;
                player.transform.Translate(0, speed, 0);
            }
        }
        else
        {
            speed = speed - .0008f;
            if (speed < 0f)
            {
                speed = 0f;
            }
            else
            {
                player.transform.Translate(0, speed, 0);
            }
        }

        // Holding down S key to slow down
        if (Input.GetKey("s"))
        {
            if (speed > 0f)
            {
                speed = speed - 0.001f;
                player.transform.Translate(0, speed, 0);
            }
        }

        // Holding down the A key to turn left
        if (Input.GetKey("a"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = leftTurn;
            if (rotationSpeed < 2f)
            {
                rotationSpeed = rotationSpeed + .1f;
                if (speed > 0f)
                {
                    player.transform.Rotate(0, 0, rotationSpeed);
                }
            }
            else
            {
                rotationSpeed = 2f;
                if (speed > 0f)
                {
                    player.transform.Rotate(0, 0, rotationSpeed);
                }
            }
        }
        else
        {
            if (rotationSpeed > 0f)
            {
                rotationSpeed = rotationSpeed - 2f;
                player.transform.Rotate(0, 0, rotationSpeed);
                if (rotationSpeed < 0f)
                {
                    rotationSpeed = 0f;
                }
            }
        }

        // Holding down the D key to turn left
        if (Input.GetKey("d"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = rightTurn;
            if (rotationSpeed > -2f)
            {
                rotationSpeed = rotationSpeed - .1f;
                if (speed > 0f)
                {
                    player.transform.Rotate(0, 0, rotationSpeed);
                }
            }
            else
            {
                rotationSpeed = -2f;
                if (speed > 0f)
                {
                    player.transform.Rotate(0, 0, rotationSpeed);
                }
            }
        }
        else
        {
            if (rotationSpeed < 0f)
            {
                rotationSpeed = rotationSpeed + 2f;
                player.transform.Rotate(0, 0, rotationSpeed);
                if (rotationSpeed > 0f)
                {
                    rotationSpeed = 0f;
                }
            }
        }
    }
}