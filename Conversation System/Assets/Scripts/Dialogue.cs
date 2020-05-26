using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public int pressYes;
    public int pressNo;
    public int line;
    public Text dialogueText;
    public Text Yes;
    public Text No;

    public void PressYes()
    {
        //    line *= 1 + 1;
        //Yes = transform.Find("Yes").GetComponent<Text>();
        pressYes += 1;
        if (pressYes == 1)
        {
            dialogueText.text = "Is goed dan. Wat vindt je van Rood?";
            Yes.text = "Mooi";
            No.text = "Lelijk";
        }
        if (pressYes == 2)
        {
            dialogueText.text = "Wat vind je dan van oranje?";
        }
    }
    public void PressNo()
    {
        //  line *= 2 + 1;
        pressNo += 1;
        if (pressNo == 1)
        {
            dialogueText.text = "Vind je blauw leuk?";
        }
        if (pressNo == 2)
        {
            dialogueText.text = "Wat vind je dan van groen?";

        }
        if (pressNo == 3)
        {
            dialogueText.text = "Wat vind je dan van geel?";

        }
    }
}
