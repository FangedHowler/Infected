using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionPoison : MonoBehaviour
{
    public int hitDamage;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().DoDamage(hitDamage);
            Destroy(gameObject);
        }
    }
}
