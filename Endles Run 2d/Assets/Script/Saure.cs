using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saure : MonoBehaviour
{
    public AudioSource hit;
    float lautst�rke = 1f;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            Handheld.Vibrate();
            hit.Play();
            gameObject.GetComponent<AudioSource>().volume = lautst�rke;
            Debug.Log("tod s�ure");
            PlayerPrefs.SetInt("s�ure", PlayerPrefs.GetInt("s�ure") + 1);

            GameObject.Find("UI_Handler").GetComponent<UI_Handler>().GameOver();
        }
    }
    void Start()
    {
        lautst�rke = PlayerPrefs.GetFloat("Sound");

    }
}
