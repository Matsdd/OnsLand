using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScript : MonoBehaviour
{
    public GameObject crops;
    public GameObject Field;
    public Vector3 vect;
    public Quaternion quat;
    public GameObject well;
    public bool positionSet = false;

    // Start is called before the first frame update
    void TheStart(Vector3 vec)
    {
        //transform.position = vec;
        vect = vec;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        if (!positionSet)
        {
            vect.x += -1.7f;
            vect.y += 1f;
            vect.z -= -2f;
            positionSet = true;
        }
        Debug.Log(InventoryScript.wheatSeeds);
        if (InventoryScript.wheatSeeds > 0)
        {
            Instantiate(crops, vect, quat);
            InventoryScript.wheatSeeds--;
        }
    }
}