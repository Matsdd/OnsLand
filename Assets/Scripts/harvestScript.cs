using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harvestScript : MonoBehaviour
{
    public GameObject crops;

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        DestroyImmediate(this.crops, true);
            InventoryScript.buckwheat++;
    }
}