using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SellScript : MonoBehaviour
{
    public string kind;
    public TMP_Text txt;

    private void Start()
    {
        setCurrency();
    }

    public void onClick()
    {
        if (kind == "bo" && InventoryScript.buckwheat > 0)
        {
            InventoryScript.buckwheat--;
            InventoryScript.cash += 5;
        }else if (kind == "ta" && InventoryScript.wheat > 0)
        {
            InventoryScript.wheat--;
            InventoryScript.cash += 7;
        }
        else if (kind == "sp" && InventoryScript.spelt > 0)
        {
            InventoryScript.spelt--;
            InventoryScript.cash += 9;
        }
        else if (kind == "hu" && InventoryScript.huttentut > 0)
        {
            InventoryScript.huttentut--;
            InventoryScript.cash += 6;
        }
        else if (kind == "ap" && InventoryScript.apple > 0)
        {
            InventoryScript.apple--;
            InventoryScript.cash += 10;
        }
        else if (kind == "cr" && InventoryScript.cranberry > 0)
        {
            InventoryScript.cranberry--;
            InventoryScript.cash += 12;
        }
        else if (kind == "ho" && InventoryScript.hop > 0)
        {
            InventoryScript.hop--;
            InventoryScript.cash += 6;
        }
        else if (kind == "be" && InventoryScript.beer > 0)
        {
            InventoryScript.beer--;
            InventoryScript.cash += 40;
        }
        else if (kind == "boc" && InventoryScript.bockBeer > 0)
        {
            InventoryScript.bockBeer--;
            InventoryScript.cash += 40;
        }
        else if (kind == "cia" && InventoryScript.ciderA > 0)
        {
            InventoryScript.ciderA--;
            InventoryScript.cash += 55;
        }
        else if (kind == "cic" && InventoryScript.CiderC > 0)
        {
            InventoryScript.CiderC--;
            InventoryScript.cash += 60;
        }
        else if (kind == "co" && InventoryScript.cookie > 0)
        {
            InventoryScript.cookie--;
            InventoryScript.cash += 14;
        }
        else if (kind == "pa" && InventoryScript.pasta > 0)
        {
            InventoryScript.pasta--;
            InventoryScript.cash += 24;
        }
        else if (kind == "pan" && InventoryScript.pancake > 0)
        {
            InventoryScript.pancake--;
            InventoryScript.cash += 42;
        }
        else if (kind == "bc" && InventoryScript.cracker > 0)
        {
            InventoryScript.cracker--;
            InventoryScript.cash += 10;
        }
        else if (kind == "oi" && InventoryScript.oil > 0)
        {
            InventoryScript.oil--;
            InventoryScript.cash += 40;
        }
        setCurrency();
    }

    public void setCurrency()
    {
        if (InventoryScript.cash <= 9999)
        {
            txt.text = "Cash = " + InventoryScript.cash;
        }else
        {
            txt.text = "Cash = 9999";
        }
    }
}
