using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CropSelAmntScript : MonoBehaviour
{
    public string kind;
    public TMP_Text txt;

    private void Start()
    {
        if (kind == "Buck")
        {
            txt.text = InventoryScript.buckwheatSeeds.ToString();
        }
        else if (kind == "Wheat")
        {
            txt.text = InventoryScript.wheatSeeds.ToString();
        }
        else if (kind == "Cran")
        {
            txt.text = InventoryScript.cranberrySeeds.ToString();
        }
        else if (kind == "Apple")
        {
            txt.text = InventoryScript.appleSeeds.ToString();
        }
        else if (kind == "Spelt")
        {
            txt.text = InventoryScript.speltSeeds.ToString();
        }
        else if (kind == "Hop")
        {
            txt.text = InventoryScript.hopSeeds.ToString();
        }
        else if (kind == "Hut")
        {
            txt.text = InventoryScript.huttentutSeeds.ToString();
        }
    }
}
