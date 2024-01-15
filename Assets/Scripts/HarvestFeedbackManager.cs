using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HarvestFeedbackManager : MonoBehaviour
{
    public static string textString;
    public TMP_Text txt;
    public float time = 0;
    public static bool activate = false;
    private void Update()
    {
        if (time < 0)
        {
            txt.text = "";
        }
        else
        {
            time--;
        }

        if (activate)
        {
            set();
        }
    }
    public void set()
    {
        activate = false;
        txt.text = textString;
        time = 400;
    }
}
