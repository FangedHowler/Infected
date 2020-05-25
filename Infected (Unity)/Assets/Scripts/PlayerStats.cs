using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerStats : MonoBehaviour
{
    [Header("stats")]
    public int currentHealth;
    public int maxHealth;
    public float speed = 5;
    public int strength;
    public int defense;

    [Header("reference")]
    public PlayerHealthBar healthBar;


    public void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
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
            SceneManager.LoadScene(1);
        }
    }
    public void MaxHealth(int maxHealth)
    {

    }
}
