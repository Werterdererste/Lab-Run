using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dedzone : MonoBehaviour
{
    public AudioSource hit;
    float lautstärke = 1f;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9 && !GameObject.Find("UI_Handler").GetComponent<UI_Handler>().isgameover)
        {
            Handheld.Vibrate();
            hit.Play();
            gameObject.GetComponent<AudioSource>().volume = lautstärke;
            Debug.Log("tod gefallen");
            PlayerPrefs.SetInt("fallen", PlayerPrefs.GetInt("fallen") + 1);

            GameObject.Find("UI_Handler").GetComponent<UI_Handler>().GameOver();
        }
        
    }
    void Start()
    {
        lautstärke = PlayerPrefs.GetFloat("Sound");

    }
}

