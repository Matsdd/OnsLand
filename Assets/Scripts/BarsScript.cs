using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarsScript : MonoBehaviour
{
    public static float fillAmntG = 1;
    public static float fillAmntW;
    public static float fillAmntB;

    public Image waterBar;
    public Image groundBar;
    public Image bugBar;

    void Update()
    {
        //water
        if (WeatherScript.raining)
        {
            waterBar.fillAmount += 0.0001f;
        }
        else if (WeatherScript.snowing)
        {
            waterBar.fillAmount -= 0.000015f;
        }
        else if (WeatherScript.harshSun)
        {
            waterBar.fillAmount -= 0.00002f;
        }
        else
        {
            waterBar.fillAmount -= 0.00001f;
        }

        //grond
        if (fillAmntG > 1)
        {
            fillAmntG = 1;
        }
        if (fillAmntG < 0)
        {
            fillAmntG = 0;
        }
        groundBar.fillAmount = fillAmntG;

        //kevers
        bugBar.fillAmount = CropScript.bugFreePlots / 5;

        fillAmntB = bugBar.fillAmount;
        fillAmntW = waterBar.fillAmount;
    }
}
