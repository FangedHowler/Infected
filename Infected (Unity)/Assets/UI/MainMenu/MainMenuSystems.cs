using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSystems : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject optionsMenu;
    public void Start()
    {
        titleScreen.SetActive(true);
    }
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OptionsButtonMain()
    {
        titleScreen.SetActive(false);
        optionsMenu.SetActive(true);
    }
    public void BackButtonMain()
    {
        titleScreen.SetActive(true);
        optionsMenu.SetActive(true);
    }
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Has quit");
    }
    public void SetVolume(float volumeValue)
    {
        //No sound to play in game. Add functionality when sound is placed into game!
    }
    public void SetFullscreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;

        Debug.Log("isFullscreen is" + isFullScreen);
    }
}
