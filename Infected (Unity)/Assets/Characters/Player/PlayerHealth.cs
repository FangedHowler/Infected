using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public int playerHealth;
    public int playerHeartsAmount;

    public Image[] hearts;

    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Update()
    {
        if(playerHealth > playerHeartsAmount)
        {
            playerHealth = playerHeartsAmount;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < playerHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if(i < playerHeartsAmount)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
    public void DoDamage(int damageToDo)
    {
        playerHealth -= damageToDo;
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
    public void DoHeal(int healingToDo)
    {
        playerHealth += healingToDo;
    }
}
