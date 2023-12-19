using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarsScript : MonoBehaviour
{
    public static float fillAmntG;
    public static float fillAmntW;
    public static float fillAmntB;

    public Image waterBar;
    public Image groundBar;
    public Image bugBar;

    void Update()
    {

        if (WeatherScript.raining)
        {
            waterBar.fillAmount += 0.0001f;
        }
        else
        {
            waterBar.fillAmount -= 0.00001f;
        }

        fillAmntB = bugBar.fillAmount;
        fillAmntW = waterBar.fillAmount;
        fillAmntG = groundBar.fillAmount;
    }
}
