using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScript : MonoBehaviour
{
    public GameObject helpScreen;
    public GameObject newHelp;
    public Canvas can;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void onClick()
    {
        newHelp = Instantiate(helpScreen);
        newHelp.transform.parent = can.transform;
    }
}
