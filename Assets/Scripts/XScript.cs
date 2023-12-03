using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XScript : MonoBehaviour
{
    public GameObject ths;
    public bool crop;
    public void onClick()
    {
        Destroy(ths);
        if (crop)
        {
            PlantScript.cropSelecting = false;
        }
    }
}
