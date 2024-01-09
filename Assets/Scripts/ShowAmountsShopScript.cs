using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowAmountsShopS : MonoBehaviour
{
    public TMP_Text txt;
    public string kind;

    void Update()
    {
        if (kind == "bo")
        {
            txt.text = "Jij hebt:\n" + InventoryScript.buckwheatSeeds;
        }else if (kind == "ta")
        {
            txt.text = "Jij hebt:\n" + InventoryScript.wheatSeeds;
        }
        else if (kind == "sp")
        {
            txt.text = "Jij hebt:\n" + InventoryScript.speltSeeds;
        }
        else if (kind == "hu")
        {

            txt.text = "Jij hebt:\n" + InventoryScript.huttentutSeeds;
        }
        else if (kind == "ho")
        {

            txt.text = "Jij hebt:\n" + InventoryScript.hopSeeds;
        }
        else if (kind == "ap")
        {

            txt.text = "Jij hebt:\n" + InventoryScript.appleSeeds;
        }
        else if (kind == "cr")
        {

            txt.text = "Jij hebt:\n" + InventoryScript.cranberrySeeds;
        }
    }
}
