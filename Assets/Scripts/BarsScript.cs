using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarsScript : MonoBehaviour
{
    public Image WaterBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (WeatherScript.raining)
        {
            WaterBar.fillAmount += 0.0001f;
        }
        else
        {
            WaterBar.fillAmount -= 0.00001f;
        }
    }
}
