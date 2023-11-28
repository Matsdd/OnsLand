using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{
    public TMP_Text txt;

    void Update()
    {
        var cash = InventoryScript.cash;
        txt.text = "Cash = " + cash;
    }
}
