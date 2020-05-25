using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuFunctions : MonoBehaviour
{
    public GameObject PauseScreen;
    public GameObject buildAbear;
    public GameObject diary;
    public GameObject setting;

    public void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            OpenPauseScreen();
        }
    }
    public void OpenPauseScreen()
    {
        Time.timeScale = 0f;
        buildAbear.SetActive(true);
        diary.SetActive(false);
        setting.SetActive(false);
    }
    public void ClosePauseScreen()
    {
        Time.timeScale = 1f;
        buildAbear.SetActive(false);
        diary.SetActive(false);
        setting.SetActive(false);
    }
    public void BuildAbearPage()
    {
        buildAbear.SetActive(true);
        diary.SetActive(false);
        setting.SetActive(false);
    }
    public void DiaryPage()
    {
        buildAbear.SetActive(false);
        diary.SetActive(true);
        setting.SetActive(false);
    }
    public void SettingsPage()
    {
        buildAbear.SetActive(false);
        diary.SetActive(false);
        setting.SetActive(true);
    }
}
