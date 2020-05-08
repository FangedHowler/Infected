using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    public int coinValue;
    public int coinAmount;
    void Update()
    {
        CoinSpin();
    }
    void CoinSpin()
    {
        transform.Rotate(1, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CoinCounter.coinAmount += coinValue;
            Destroy(gameObject);
        }
    }
}