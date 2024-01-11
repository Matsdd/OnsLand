using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftScript : MonoBehaviour
{
    public int craftingId;
    public RawImage craftImg;
    public float colortimer = 0;

    private void Update()
    {
        if (colortimer > 0)
        {
            colortimer--;
        }else
        {
            craftImg.color = Color.white;
        }
    }
    public void onClick()
    {
        if (craftingId == 1)
        {
            //PILS
            if (InventoryScript.hop > 2 && InventoryScript.buckwheat > 2) 
            {
                InventoryScript.hop -= 3;
                InventoryScript.buckwheat -= 3;
                InventoryScript.beer++;
                craftImg.color = Color.green;
                colortimer = 100;
            }
            else
            {
                craftImg.color = Color.red;
                colortimer = 100;
            }
        }
        else if (craftingId == 2)
        {
            //bockbier
            if (InventoryScript.hop > 2 && InventoryScript.spelt > 1)
            {
                InventoryScript.hop -= 3;
                InventoryScript.spelt -= 2;
                InventoryScript.bockBeer++;
                craftImg.color = Color.green;
                colortimer = 100;
            }
            else
            {
                craftImg.color = Color.red;
                colortimer = 100;
            }
        }
        else if (craftingId == 4)
        {
            //cider cranberry
            if (InventoryScript.hop > 1 && InventoryScript.buckwheat > 1 && InventoryScript.cranberry > 2)
            {
                InventoryScript.hop -= 2;
                InventoryScript.buckwheat -= 2;
                InventoryScript.cranberry -= 3;
                InventoryScript.CiderC++;

                craftImg.color = Color.green;
                colortimer = 100;
            }
            else
            {
                craftImg.color = Color.red;
                colortimer = 100;
            }
        }
        else if (craftingId == 4)
        {
            //cider appel
            if (InventoryScript.hop > 1 && InventoryScript.buckwheat > 1 && InventoryScript.apple > 2)
            {
                InventoryScript.hop -= 2;
                InventoryScript.buckwheat -= 2;
                InventoryScript.apple -= 3;
                InventoryScript.ciderA++;

                craftImg.color = Color.green;
                colortimer = 100;
            }
            else
            {
                craftImg.color = Color.red;
                colortimer = 100;
            }
        }
    }
}
