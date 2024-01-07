using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FieldCostScript : MonoBehaviour
{
    public TMP_Text costTxt;
    void Update()
    {
        costTxt.text = "Prijs grond:\n€" + (RemoveSignScript.fieldsUnlocked * RemoveSignScript.fieldsUnlocked * 10 + 5);
    }
}
