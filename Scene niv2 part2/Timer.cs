using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour

{
    public GameObject selectedPices;

    public float timeStart;
    public Text TimerTxt;
    public bool TimerOn = false;


    public void ScenePerdu()
    {
        SceneManager.LoadScene("Sperdu");
    }

    void Start()

    {
        timeStart = 180f;
        TimerOn = true;
        // textBox.text=timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // timeStart -= Time. deltaTime;
        if (TimerOn)
        {
            if (timeStart > 0)
            {
                timeStart -= Time.deltaTime;
                updateTimer(timeStart);
            }
            else
            {

                //Debug.Log("Time is UP!");
                timeStart = 0;
                TimerOn = false;
                SceneManager.LoadScene("Sperdu");

            }
        }



        void updateTimer(float currentTime)
        {
            currentTime += 1;

            float minutes = Mathf.FloorToInt(currentTime / 60);
            float seconds = Mathf.FloorToInt(currentTime % 60);

            TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        // updateTimer(timeStart);
    }
}