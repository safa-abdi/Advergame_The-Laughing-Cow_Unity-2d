using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] picture;


    public float timeStart;
    public Text TimerTxt ;
    public bool TimerOn = false;
    public bool GameOver;
    public static bool gain;
    public Transform title;
    public Transform gainPage;

    void Start()

    {
        timeStart = 30f;
        TimerOn = true;
        GameOver = false;
        gain = false;
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
                if (picture[0].rotation.z == 0 &&
                     picture[1].rotation.z == 0 &&
                     picture[2].rotation.z == 0 &&
                     picture[3].rotation.z == 0 &&
                     picture[4].rotation.z == 0 &&
                     picture[5].rotation.z == 0 &&
                     picture[6].rotation.z == 0 &&
                     picture[7].rotation.z == 0 &&
                     picture[8].rotation.z == 0 &&
                     picture[9].rotation.z == 0 &&
                     picture[10].rotation.z == 0 &&
                     picture[11].rotation.z == 0 &&
                     picture[12].rotation.z == 0 &&
                     picture[13].rotation.z == 0 &&
                     picture[14].rotation.z == 0 &&
                     picture[15].rotation.z == 0)
                {
                    gain = true;
                }
                else
                {
                    timeStart -= Time.deltaTime;
                    updateTimer(timeStart);
                }
            }
            else
            {
                //Debug.Log("Time is UP!");
                timeStart = 0;
                TimerOn = false;
                GameOver = true;

            }
        }
        if (GameOver == true)
        {
            title.localPosition = new Vector3(0f, 0f, 0f);
            GameOver = false;
        }
        else if (gain == true)
        {
            gainPage.localPosition = new Vector3(0f, 0f, 0f);
            gain = false;
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