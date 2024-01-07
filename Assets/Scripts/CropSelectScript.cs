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
    public GameObject newCrops;
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
        if (InventoryScript.buckwheatSeeds > 0 && ((WeatherScript.snowing && BarsScript.fillAmntG > 0.22f) || (!WeatherScript.snowing && BarsScript.fillAmntG > 0.14f)))
        {
            newCrops = Instantiate(crops, vec, quat);
            newCrops.SendMessage("TheStart", "Buckwheat");
            InventoryScript.buckwheatSeeds--;
            Destroy(ths);

            PlantScript.cropSelecting = false;

            if (WeatherScript.snowing)
            {
                BarsScript.fillAmntG -= 0.22f;
            }
            else
            {
                BarsScript.fillAmntG -= 0.14f;
            }
        }
    }
    public void onClickWheat()
    {
        if (InventoryScript.wheatSeeds > 0 && ((WeatherScript.snowing && BarsScript.fillAmntG > 0.22f) || (!WeatherScript.snowing && BarsScript.fillAmntG > 0.14f)))
        {
            newCrops = Instantiate(crops, vec, quat);
            newCrops.SendMessage("TheStart", "Wheat");
            InventoryScript.wheatSeeds--;
            Destroy(ths);

            PlantScript.cropSelecting = false;

            if (WeatherScript.snowing)
            {
                BarsScript.fillAmntG -= 0.22f;
            }
            else
            {
                BarsScript.fillAmntG -= 0.14f;
            }
        }
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
