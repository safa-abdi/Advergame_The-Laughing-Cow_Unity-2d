using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dragDrap : MonoBehaviour
{
   public GameObject selectedP;

   public float timeStart ;
   public Text TimerTxt;
   public bool TimerOn = false;
    public bool GameOver;
    public static bool gain;
    public Transform title;
    public Transform gainPage;

    // Start is called before the first frame update
    void Start()
    {
        selectedP = GameObject.FindWithTag ("img");

        timeStart = 180f;
        TimerOn = true;
        GameOver = false;
        gain = false;
    }

    // Update is called once per frame
    void Update()
    {
      if(TimerOn)
        {
            if( timeStart > 0)
            {
                 timeStart -= Time.deltaTime;
                 updateTimer( timeStart);
            }
            else
            {
                 RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
                 timeStart = 0;
                 TimerOn = false;
                 GameOver = true;
                if (hit.transform.CompareTag("img"))
            {

              // if (hit.transform.GetComponent<piecesPuzz>().InRightPos)
               // {
               selectedP = hit.transform.gameObject;
               //selectedP.GetComponent<piecesPuzz>().selectedd=true;
               // }


              
            }
                
                Debug.Log("Time is UP!");
                timeStart = 0;
                TimerOn = false;
              
                
            }
            if (GameOver == true)
            {
                title.localPosition = new Vector3(0f, 0f, 0f);
                GameOver = false;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            if (hit.transform.CompareTag("img"))
            {

              // if (hit.transform.GetComponent<piecesPuzz>().InRightPos)
               // {
               selectedP = hit.transform.gameObject;
               //selectedP.GetComponent<piecesPuzz>().selectedd=true;
               // }


              
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
        // selectedP.GetComponent<piecesPuzz>().selectedd=false;
         selectedP=null;
        }
        if(selectedP != null)
        {
            Vector3 MousePoint= Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectedP.transform.position=  new Vector3(MousePoint.x,MousePoint.y,0);
        }
    }

 void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
