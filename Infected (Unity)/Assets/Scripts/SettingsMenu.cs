using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Quitgame()
    {
        Application.Quit();
        Debug.Log("Has quit");
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
