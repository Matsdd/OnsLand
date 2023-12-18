using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundBarScript : MonoBehaviour
{
    public static float fillAmnt = 1f;
    public Image groundBar;

    private void Update()
    {
        if (fillAmnt > 1)
        {
            fillAmnt = 1;
        }
        if (fillAmnt < 0)
        {
            fillAmnt = 0;
        }
        groundBar.fillAmount = fillAmnt;
    }
}
