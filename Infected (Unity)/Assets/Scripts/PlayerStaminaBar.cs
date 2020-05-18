using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStaminaBar : MonoBehaviour
{
    public Slider staminaSlider;
    public void SetMaxStamina(int maxStamina)
    {
        staminaSlider.maxValue = maxStamina;
        staminaSlider.value = maxStamina;
    }
    public void SetStamina(int stamina)
    {
        staminaSlider.value = stamina;
    }
    public void SetMinStamina(int minStamina)
    {
        staminaSlider.minValue = minStamina;
        staminaSlider.value = minStamina;
    }
}
