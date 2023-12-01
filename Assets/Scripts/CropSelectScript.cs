using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropSelectScript : MonoBehaviour
{
    public GameObject crops;
    public Vector3 vec;
    public Quaternion quat;
    public GameObject ths;
    // Start is called before the first frame update
    void TheStart(Vector3 vect)
    {
        vec = vect;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick()
    {
        if (InventoryScript.buckwheatSeeds > 0)
        {
            Instantiate(crops, vec, quat);
            InventoryScript.buckwheatSeeds--;
            Destroy(ths);
        }
    }
}
