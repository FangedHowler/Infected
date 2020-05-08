using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorSystem : MonoBehaviour
{
    public GameObject operatorSystem;
    public bool isPaused;
    public void Start()
    {
        operatorSystem.SetActive(true);
        Time.timeScale = 0;
    }
    public void ContinueButton()
    {
        operatorSystem.SetActive(false);
        Time.timeScale = 1;
    }
}
