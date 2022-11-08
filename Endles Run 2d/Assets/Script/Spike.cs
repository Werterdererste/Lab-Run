using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public AudioSource hit;
    float lautstärke = 1;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            Handheld.Vibrate();
            hit.Play();
            gameObject.GetComponent<AudioSource>().volume = lautstärke;
            Debug.Log("tod aufgespießt");
            PlayerPrefs.SetInt("spike", PlayerPrefs.GetInt("spike") + 1);
            GameObject.Find("UI_Handler").GetComponent<UI_Handler>().GameOver();

        }
    }
    void Start()
    {
        lautstärke = PlayerPrefs.GetFloat("Sound");

    }
}
