using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeScript : MonoBehaviour
{
    public static bool welcomed = false;
    public GameObject ths;

    private void Start()
    {
        if (welcomed)
        {
            Destroy(ths);
        }
    }
}
