using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public void onClickBuck()
    {
        if (InventoryScript.buckwheatSeeds > 0)
        {
            Instantiate(crops, vec, quat);
            InventoryScript.buckwheatSeeds--;
            Destroy(ths);

            PlantScript.cropSelecting = false;

            GroundBarScript.fillAmnt -= 0.1f;
        }
    }
    public void onClickWheat()
    {

    }

    public void onClickHut()
    {

    }

    public void onClickSpelt()
    {

    }

    public void onClickOat()
    {

    }

    public void onClickRye()
    {

    }

    public void onClickHop()
    {

    }

    public void onClickApple()
    {

    }

    public void onClickCran()
    {

    }
}
