using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Säge : MonoBehaviour
{
    public int Speed = 10;
    public AudioSource hit;
    float lautstärke = 1f;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            Handheld.Vibrate();
            hit.Play();
            gameObject.GetComponent<AudioSource>().volume = lautstärke;
            Debug.Log("tod zersägt");
            PlayerPrefs.SetInt("zersägt", PlayerPrefs.GetInt("zersägt") + 1);

            GameObject.Find("UI_Handler").GetComponent<UI_Handler>().GameOver();
        }
    }
    void Update()
    {
        transform.Rotate(new Vector3(0,0,Speed* Time.deltaTime));
    }
    void Start()
    {
        lautstärke = PlayerPrefs.GetFloat("Sound");

    }
}
