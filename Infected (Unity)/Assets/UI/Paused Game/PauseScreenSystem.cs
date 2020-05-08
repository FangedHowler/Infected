using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScreenSystem : MonoBehaviour
{
    public GameObject pauseMain;
    public GameObject pauseOptions;
    
    public static bool gameIsPaused;
    public void Start()
    {
        pauseMain.SetActive(false);
        pauseOptions.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (gameIsPaused)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Continue()
    {
        pauseMain.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }
    public void Pause()
    {
        pauseMain.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }
    public void ContinueButton()
    {
        pauseMain.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }
    public void ToOptions()
    {
        pauseOptions.SetActive(true);
        pauseMain.SetActive(false);
        Time.timeScale = 0;
        gameIsPaused = true;
    }
    public void ToPauseMain()
    {
        pauseOptions.SetActive(false);
        pauseMain.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }
    public void SetVolume()
    {
        //No sound to play in game. Add functionality when sound is placed into game!
    }
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;

        Debug.Log("isFullscreen is" + isFullScreen);
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Has Quit");
    }
}
