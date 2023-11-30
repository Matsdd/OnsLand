using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainArrowScript : MonoBehaviour
{
    public float side;
    public Camera cam;
    public float clicked = 0;

    public void onClick()
    {
        if (clicked == 0)
        {
            clicked = 25;
        }
    }

    private void Update()
    {
        if (clicked > 0)
        {
            cam.transform.position += new Vector3(side * 4, 0, 0);
            clicked--;
        }
    }
}
