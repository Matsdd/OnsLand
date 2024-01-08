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
        if (InventoryScript.huttentutSeeds > 0 && ((WeatherScript.snowing && BarsScript.fillAmntG > 0.22f) || (!WeatherScript.snowing && BarsScript.fillAmntG > 0.14f)))
        {
            newCrops = Instantiate(crops, vec, quat);
            newCrops.SendMessage("TheStart", "Hut");
            InventoryScript.huttentutSeeds--;
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

    public void onClickSpelt()
    {
        if (InventoryScript.speltSeeds > 0 && ((WeatherScript.snowing && BarsScript.fillAmntG > 0.22f) || (!WeatherScript.snowing && BarsScript.fillAmntG > 0.14f)))
        {
            newCrops = Instantiate(crops, vec, quat);
            newCrops.SendMessage("TheStart", "Spelt");
            InventoryScript.speltSeeds--;
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

    public void onClickOat()
    {
        if (InventoryScript.oatSeeds > 0 && ((WeatherScript.snowing && BarsScript.fillAmntG > 0.22f) || (!WeatherScript.snowing && BarsScript.fillAmntG > 0.14f)))
        {
            newCrops = Instantiate(crops, vec, quat);
            newCrops.SendMessage("TheStart", "Oat");
            InventoryScript.oatSeeds--;
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

    public void onClickRye()
    {
        if (InventoryScript.ryeSeeds > 0 && ((WeatherScript.snowing && BarsScript.fillAmntG > 0.22f) || (!WeatherScript.snowing && BarsScript.fillAmntG > 0.14f)))
        {
            newCrops = Instantiate(crops, vec, quat);
            newCrops.SendMessage("TheStart", "Rye");
            InventoryScript.ryeSeeds--;
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

    public void onClickHop()
    {
        if (InventoryScript.hopSeeds > 0 && ((WeatherScript.snowing && BarsScript.fillAmntG > 0.22f) || (!WeatherScript.snowing && BarsScript.fillAmntG > 0.14f)))
        {
            newCrops = Instantiate(crops, vec, quat);
            newCrops.SendMessage("TheStart", "Hop");
            InventoryScript.hopSeeds--;
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

    public void onClickApple()
    {
        if (InventoryScript.appleSeeds > 0 && ((WeatherScript.snowing && BarsScript.fillAmntG > 0.22f) || (!WeatherScript.snowing && BarsScript.fillAmntG > 0.14f)))
        {
            newCrops = Instantiate(crops, vec, quat);
            newCrops.SendMessage("TheStart", "Apple");
            InventoryScript.appleSeeds--;
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

    public void onClickCran()
    {
        if (InventoryScript.cranberrySeeds > 0 && ((WeatherScript.snowing && BarsScript.fillAmntG > 0.22f) || (!WeatherScript.snowing && BarsScript.fillAmntG > 0.14f)))
        {
            newCrops = Instantiate(crops, vec, quat);
            newCrops.SendMessage("TheStart", "Cran");
            InventoryScript.cranberrySeeds--;
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
}
