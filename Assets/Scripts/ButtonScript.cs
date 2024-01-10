using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public bool openUrl = false;
    public int scene;
    public static int prevscene;

    private void Start()
    {
    }

    private void Update()
    {

    }
    void OnMouseDown()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void onClick()
    {
        if (openUrl)
        {
            if (CropScript.gameRunning)
            {
                Application.OpenURL("https://landvanons.nl/");
            }
        }
        else
        {
            // mainscene hoeft niet aangemaakt te worden
            if (scene == 0)
            {
                if (prevscene != 0)
                {
                    SceneManager.UnloadSceneAsync(prevscene);
                    CropScript.gameRunning = true;
                    CropScript.ablePause = true;
                }
            }
            else
            {
                if (CropScript.gameRunning)
                {
                    SceneManager.LoadScene(scene, LoadSceneMode.Additive);
                    CropScript.gameRunning = false;
                    CropScript.ablePause = false;
                }
            }
            prevscene = scene;
        }
        
    }
}
