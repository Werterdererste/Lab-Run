using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menühandler : MonoBehaviour
{
    public GameObject[] caracter;

    public void Caracter()
    {
        int num = PlayerPrefs.GetInt("Player");

        for (int i = 0; i < caracter.Length; i++)
        {
            if (num == i)
            {
                caracter[i].SetActive(true);
            }
            else
            {
                caracter[i].SetActive(false);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Caracter();
    }

}
