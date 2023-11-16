using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public int scene;
    void OnMouseDown()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
