using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinCountertext;
    public static int coinAmount;
    public void Start()
    {
        coinCountertext.GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        coinCountertext.text = coinAmount.ToString();
    }
}