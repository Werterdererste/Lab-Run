using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coinsound;
    float lautstärke = 1f;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
           GameObject sound = Instantiate(coinsound, transform.position, Quaternion.identity);
            sound.GetComponent<AudioSource>().volume = lautstärke;
            Destroy(sound, 2);
            PlayerPrefs.SetInt("Coin",PlayerPrefs.GetInt("Coin")+1 );
            PlayerPrefs.SetInt("gcoins", PlayerPrefs.GetInt("gcoins")+1);
            UI_Handler.inRundeCoins++;
            
            Destroy(gameObject);
        }
    }
    void Start()
    {
        lautstärke = PlayerPrefs.GetFloat("Sound");

    }
}
