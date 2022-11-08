using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shop : MonoBehaviour
{
    public Text Geld;
    
    // Start is called before the first frame update
    void Start()
    {
        SafeFreigeschalten(0);
    }

    // Update is called once per frame
    void Update()
    {
        Geld.text = PlayerPrefs.GetInt("Coin").ToString();  
    }

    public void Kauf1()
    {
        int preis = 10;
        int caracter = 0;
        kaufprozes(caracter, preis);
    }
    public void Kauf2()
    {
        int preis = 100;
        int caracter = 1;
        kaufprozes(caracter, preis);
    }
    public void Kauf3()
    {
        int preis = 200;
        int caracter = 2;
        kaufprozes(caracter, preis);
    }
    public void Kauf4()
    {
        int preis = 500;
        int caracter = 3;
        kaufprozes(caracter, preis);
    }
    public void kaufprozes(int caracter, int preis)
    {
        //ist bereits freigeschaltet?
        if(IsFreigeschaltet(caracter) == false)
        { 
            //genug geld?
            if(preis<= PlayerPrefs.GetInt("Coin"))
            {
                Debug.Log("kaufen");
                // Geld abzihen
                PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") - preis);
                //freischaltern Auswälen
                SafeFreigeschalten(caracter);
                PlayerPrefs.SetInt("Player", caracter);
            }
            else
            {
                Debug.Log("zu wenig geld");
            }
        }
        else
        {
            Debug.Log("bereits freigeschaltet");
            PlayerPrefs.SetInt("Player", caracter);
        }

    }

    public void SafeFreigeschalten(int caracter)
    {
        //speichert untem
        PlayerPrefs.SetString(caracter.ToString() + "caracter" , "true");
    }
    public bool IsFreigeschaltet(int caracter)
    {
        bool isfreigeschaltet;
        string freigeschaltet = PlayerPrefs.GetString(caracter.ToString() + "caracter");
        if (freigeschaltet == "true")
        {
            isfreigeschaltet = true;
        }
        else
        {
            isfreigeschaltet = false;
        }
        return isfreigeschaltet; ;
    }
    
}
