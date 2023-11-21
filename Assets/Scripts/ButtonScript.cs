using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public bool openUrl = false;
    public int scene;

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
            Application.OpenURL("https://landvanons.nl/");
        }
        else
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
    }
}
