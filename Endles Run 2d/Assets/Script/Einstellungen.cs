using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Einstellungen : MonoBehaviour
{
    public Slider sound;
    public Slider music;

    
    // Start is called before the first frame update
    void Start()
    {
        sound.GetComponent<Slider>();
        music.GetComponent<Slider>();

        if (PlayerPrefs.GetInt("erstesmal") != 0)
        {
            music.value = PlayerPrefs.GetFloat("Music");
            sound.value = PlayerPrefs.GetFloat("Sound");
        }
        else
            PlayerPrefs.SetInt("erstesmal", 1);   
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(music.value);
        PlayerPrefs.SetFloat("Music", music.value);
        PlayerPrefs.SetFloat("Sound", sound.value);
    }
}
