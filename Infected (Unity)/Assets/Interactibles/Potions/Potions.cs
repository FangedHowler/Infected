using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potions : MonoBehaviour
{
    public int hitHeal;
    public int hitDamage;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Touch();
        }
    }
    public virtual void Touch()
    {
        print(base.name);
    }
}
