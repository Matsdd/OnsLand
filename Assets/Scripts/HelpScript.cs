using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScript : MonoBehaviour
{
    public Canvas helpScreen;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void onClick()
    {
        if (WelcomeScript.welcomed)
        {
            Instantiate(helpScreen);
        }
    }

}
