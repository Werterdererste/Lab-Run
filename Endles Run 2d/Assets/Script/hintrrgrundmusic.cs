using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintrrgrundmusic : MonoBehaviour
{
    public AudioClip music;
    private AudioSource back;
    float Lautst�rke = 0.5f;
    void Start()
    {
        back = this.GetComponent<AudioSource>();
        back.loop = true;
        Lautst�rke = PlayerPrefs.GetFloat("Music");
        back.volume = Lautst�rke;
        back.clip = music;
        back.Play();
    }
}
