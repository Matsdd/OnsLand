using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{
    public TMP_Text txt;
    public GameObject inventory;

    void Update()
    {
        var cash = inventory.GetComponent<InventoryScript>().cash;
        txt.text = "Cash = " + cash;
    }
}
