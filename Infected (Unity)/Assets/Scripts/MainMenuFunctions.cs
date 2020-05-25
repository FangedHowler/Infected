using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunctions : MonoBehaviour
{
    public GameObject settingsPopUp;
    public Slider volumeSlider;
    public Toggle[] resolutionToggles;
    public int[] screenWidths;

    public void Start()
    {
        settingsPopUp.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("has quit game");
    }
    public void SettingsOn()
    {
        settingsPopUp.SetActive(true);
    }
    public void SettingsOff()
    {
        settingsPopUp.SetActive(false);
    }
    public void FullScreenToggle(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        Debug.Log("Is fullscreen" + isFullScreen);
    }
    public void SetVolume(int value)
    {

    }
    public void SetScreenRes1()
    {
        Screen.SetResolution(1920, 1080, true);
        Debug.Log("setScreenSize 1920x1080");
    }
    public void SetScreenRes2()
    {
        Screen.SetResolution(1280, 720, false);
        Debug.Log("setScreenSize 1280x720");
    }
    public void SetScreenRes3()
    {
        Screen.SetResolution(960, 540, false);
        Debug.Log("setScreenSize 960x540");
    }
}
