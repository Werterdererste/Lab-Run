using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenmaneger : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene("Game");
        UI_Handler.inRundeCoins = 0;
        UI_Handler.newhigscore = false;
    }
    public void Menü()
    {
        SceneManager.LoadScene("Menü");
        Time.timeScale = 1;
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void PauseButon()
    {
        GameObject.Find("UI_Handler").GetComponent<UI_Handler>().Pause();
    }
    public void Wetersgames()
    {
        Application.OpenURL("https://play.google.com/store/apps/dev?id=5619463132150775027&hl=de");
    }
    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }
    public void Einstellungen()
    {
        SceneManager.LoadScene("Einstellungen");
    }
    public void Statistic()
    {
        SceneManager.LoadScene("Statistic");
    }
}
