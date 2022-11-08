using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistic : MonoBehaviour
{
    public Text Record;
    public Text Gelaufen;
    public Text Gesprungen;
    public Text Coins;
    public Text Tode;
    public Text Gefallen;
    public Text Zers‰gt;
    public Text S‰ure;
    public Text Aufgespiest;
    public Text Zohne;
    // Start is called before the first frame update
    void Start()
    {
        Record.GetComponent<Text>();
        Gelaufen.GetComponent<Text>();
        Gesprungen.GetComponent<Text>();
        Coins.GetComponent<Text>();
        Tode.GetComponent<Text>();
        Gefallen.GetComponent<Text>();
        Zers‰gt.GetComponent<Text>();
        S‰ure.GetComponent<Text>();
        Aufgespiest.GetComponent<Text>();
        Zohne.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Record.text = "Hiscore: " + PlayerPrefs.GetFloat("higscore");
        Gelaufen.text = "Gelaufen: " + PlayerPrefs.GetInt("gelaufen");
        Gesprungen.text = "Gesprungen: " + PlayerPrefs.GetInt("jump");
        Coins.text = "Coins: " + PlayerPrefs.GetInt("gcoins");
        Tode.text = "Tode: " + PlayerPrefs.GetInt("tode");
        Gefallen.text = "Gefallen: " + PlayerPrefs.GetInt("fallen");
        Zers‰gt.text = "Zers‰gt: " + PlayerPrefs.GetInt("zers‰gt");
        S‰ure.text = "S‰ure: " + PlayerPrefs.GetInt("s‰ure");
        Aufgespiest.text = "Aufgespieﬂt: " + PlayerPrefs.GetInt("spike");
        Zohne.text = "Zohne: " + PlayerPrefs.GetInt("zohne");
    }
}
