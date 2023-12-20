using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{
    public TMP_Text txt;
    public float type;

    void Update()
    {
        if (type == 1)
        {
            var cash = InventoryScript.cash;
            txt.text = "Cash = " + cash;
        }else if (type == 2)
        {
            var temp = WeatherScript.temp;
            txt.text = temp + "°C";
        }else if (type == 3)
        {
            var month = WeatherScript.month;
            txt.text = month;
        }
    }
}
