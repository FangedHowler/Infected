using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerStats : MonoBehaviour
{
    [Header("Health")]
    public int currentHealth;
    public int maxHealth;

    [Header("Stamina")]
    public int maxStamina;
    public int currentStamina;

    [Header("UI elements")]
    public PlayerHealthBar healthBar;

    public void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            TakeDamage(2);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            Application.LoadLevel(1);
        }
    }

}
