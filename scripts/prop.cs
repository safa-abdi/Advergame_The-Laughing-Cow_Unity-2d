using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prop : MonoBehaviour
{
    public GameObject Panel;
    bool visible = false;
    public Dropdown DResolution;
    public AudioSource audiosource;

    public Slider slider;
    public Text TxtVolume;

    private void Start() => SliderChanger();

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            visible = !visible;
            Panel.SetActive(visible);
        }
    }
    public void SetResolution()
    {
        switch(DResolution.value)
        {
            case 0:
                Screen.SetResolution(640, 360, true);
                break;
            case 1:
                Screen.SetResolution(1920, 1080, true);
                break;


        }
    }
    public void SliderChanger()
    {
        audiosource.volume = slider.value;
        TxtVolume.text = "Volume " + (audiosource.volume * 100).ToString("00") + "%";
    }
}
