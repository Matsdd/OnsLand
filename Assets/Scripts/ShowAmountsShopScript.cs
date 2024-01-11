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
        else if (kind == "boe")
        {
            txt.text = "Jij hebt:\n" + InventoryScript.buckwheat;
        }
        else if (kind == "tar")
        {
            txt.text = "Jij hebt:\n" + InventoryScript.wheat;
        }
        else if (kind == "hut")
        {

            txt.text = "Jij hebt:\n" + InventoryScript.huttentut;
        }
        else if (kind == "spe")
        {
            txt.text = "Jij hebt:\n" + InventoryScript.spelt;

        }
        else if (kind == "app")
        {
            txt.text = "Jij hebt:\n" + InventoryScript.apple;

        }
        else if (kind == "hop")
        {
            txt.text = "Jij hebt:\n" + InventoryScript.hop;

        }
        else if (kind == "cra")
        {

            txt.text = "Jij hebt:\n" + InventoryScript.cranberry;
        }
        else if (kind == "be")
        {

            txt.text = "Jij hebt:\n" + InventoryScript.beer;
        }
        else if (kind == "boc")
        {

            txt.text = "Jij hebt:\n" + InventoryScript.bockBeer;
        }
        else if (kind == "cia")
        {

            txt.text = "Jij hebt:\n" + InventoryScript.ciderA;
        }
        else if (kind == "cic")
        {

            txt.text = "Jij hebt:\n" + InventoryScript.CiderC;
        }
    }
}
