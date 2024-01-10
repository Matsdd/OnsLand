using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PauseScript : MonoBehaviour
{
    public TMP_Text txt;
    public GameObject help = null;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause();
        }
    }

    public void pause()
    {
        if (WelcomeScript.welcomed && CropScript.ablePause)
        {
            if (CropScript.gameRunning)
            {
                CropScript.gameRunning = false;
                txt.text = "Game paused";
            }
            else
            {
                CropScript.gameRunning = true;
                txt.text = "";
            }
        }
    }
}
