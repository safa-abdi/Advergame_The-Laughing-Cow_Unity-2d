using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioCont : MonoBehaviour
{
public AudioClip sound;
    [Range(0f,1f)]
    public float volume; //gestion du volume
    [Range(0.1f,2.5f)]
    public float pitch ;//gestion de la vitesses du morceau
    public AudioSource source;
   
  void Awake()
  {
    gameObject.AddComponent<AudioSource>();
    source=GetComponent<AudioSource>();
    volume=0.5f;
    pitch=1f;
  }

    // Start is called before the first frame update
    void Start()
    {
        source.clip=sound;
        source.volume=volume;
        source.pitch=pitch;
    }

    // Update is called once per frame
    void Update()
    {
          PlayAndPause();
    }
    public void PlayAndPause()
    {
        if(!source.isPlaying)
        {
            source.Play();
        }
       
    }
}
