using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionHealing : MonoBehaviour
{
    public int hitHeal;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().DoHeal(hitHeal);
            Destroy(gameObject);
        }
    }
}
