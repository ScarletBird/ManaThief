using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{
    public Text scoreLabel;

    public GameObject pauseMenu;

    public GameObject optionsMenu;
 
    // Use this for initialization
    void Start()
    {
        Refresh();

        pauseMenu.SetActive(false);
    }
 
    // Show player stats in the HUD
    public void Refresh()
    {
        scoreLabel.text = "Score: " + GameManager.instance.score;
    }

    public void Pause()
    {
        // Pause the game
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        optionsMenu.SetActive(false);
        GameManager.instance.isPaused = true;
    }

    public void Options()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(true);
        GameManager.instance.isPaused = true;
    }

    public void UnPause()
    {
        // Pause the game
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(false);
        GameManager.instance.isPaused = false;
    }
}
