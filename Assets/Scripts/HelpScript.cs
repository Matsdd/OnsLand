using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScript : MonoBehaviour
{
    public Canvas helpScreen;
    public static bool help;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void onClick()
    {
        if (WelcomeScript.welcomed && !help)
        {
            Instantiate(helpScreen);
            help = true;
        }
    }

}
