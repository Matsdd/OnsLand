using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Book", LoadSceneMode.Single);
    }
}
