using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public AudioSource hit;
    float lautst‰rke = 1;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            Handheld.Vibrate();
            hit.Play();
            gameObject.GetComponent<AudioSource>().volume = lautst‰rke;
            Debug.Log("tod aufgespieﬂt");
            PlayerPrefs.SetInt("spike", PlayerPrefs.GetInt("spike") + 1);
            GameObject.Find("UI_Handler").GetComponent<UI_Handler>().GameOver();

        }
    }
    void Start()
    {
        lautst‰rke = PlayerPrefs.GetFloat("Sound");

    }
}
