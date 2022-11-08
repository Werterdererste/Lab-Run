using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Handler : MonoBehaviour
{
    public Text Meteranzige;
    public Text Higscoretext;
    float playerpos = 0;

    public Transform Player;

    public GameObject gameOverGUI;
    public bool isgameover;

    public GameObject pauseGUI;
    public GameObject pauseButton;
    public static bool ispause;

    public Text geld;

    public Text PauseMeter, PauseRecord, PauseCoins;
    public Text GameoverMeter, GameOverRecord, GameoverCoins;
    public static int inRundeCoins = 0;
    public static bool  newhigscore;

     void Start()
     {
        PauseMeter.GetComponent<Text>();
        PauseRecord.GetComponent<Text>();
        PauseCoins.GetComponent<Text>();
        GameoverMeter.GetComponent<Text>();
        GameOverRecord.GetComponent<Text>();
        GameoverCoins.GetComponent<Text>();
     }
    // Update is called once per frame
    void Update()
    {
        playerpos = Mathf.Round(Player.position.x + 5);
        Meteranzige.text = playerpos.ToString();
        if (playerpos > PlayerPrefs.GetFloat("higscore"))
        {
            PlayerPrefs.SetFloat("higscore", playerpos);
            newhigscore = true;
        }
        Higscoretext.text = PlayerPrefs.GetFloat("higscore").ToString();

        geld.text = PlayerPrefs.GetInt("Coin").ToString();
        PauseAndGameOverAnzeige();
    }
    public void Jump()
    {
        GameObject.Find("Player").GetComponent<playerMovement>().jump();
    }
    public void GameOver()
    {
        isgameover = true;
        gameOverGUI.SetActive(true);
        pauseButton.SetActive(false);
        PlayerPrefs.SetInt("tode", PlayerPrefs.GetInt("tode") + 1);
        PlayerPrefs.SetInt("gelaufen", PlayerPrefs.GetInt("gelaufen") + Mathf.RoundToInt( playerpos));

    }
    public void Pause()
    {
        if (!isgameover)
        {
            if (ispause)
            {
                ispause = false;
                pauseGUI.SetActive(false);
                pauseButton.SetActive(true);
                Time.timeScale = 1;
            }
            else
            {
                ispause = true;

                pauseGUI.SetActive(true);
                pauseButton.SetActive(false);
                Time.timeScale = 0;
            }

        }
        
    }
    public void PauseAndGameOverAnzeige()
    {
        PauseMeter.text = "Gelaufen: " + playerpos.ToString();
        PauseCoins.text = "Neue Coins: " + inRundeCoins;     

        GameoverMeter.text = "Gelaufen: " + playerpos.ToString();
        GameoverCoins.text = "Neue Coins: " + inRundeCoins;

        if (newhigscore)
        {
            PauseRecord.text = "Neuer Higscore: " + PlayerPrefs.GetFloat("higscore").ToString();
            GameOverRecord.text = "Neuer Higscore: " + PlayerPrefs.GetFloat("higscore").ToString();

            PauseRecord.gameObject.SetActive(true);
            GameOverRecord.gameObject.SetActive(true);
        }
    }
}
