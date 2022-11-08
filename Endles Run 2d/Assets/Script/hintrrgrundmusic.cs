using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintrrgrundmusic : MonoBehaviour
{
    public AudioClip music;
    private AudioSource back;
    float Lautstärke = 0.5f;
    void Start()
    {
        back = this.GetComponent<AudioSource>();
        back.loop = true;
        Lautstärke = PlayerPrefs.GetFloat("Music");
        back.volume = Lautstärke;
        back.clip = music;
        back.Play();
    }
}
