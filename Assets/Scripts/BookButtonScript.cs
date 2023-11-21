using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookButtonScript : MonoBehaviour
{
    public GameObject ui;

    public float side;
    public float pageTurning = 0;
    static float currentPage = 1;

    public GameObject buttonLeft;
    public GameObject buttonRight;
    public void pageSet()
    {
        if (currentPage == 1 && side == 1)
        {
            return;
        }
        if (currentPage == 5 && side == -1)
        {
            return;
        }
        if (pageTurning <= 0)
        {
            pageTurning = 100;
            currentPage += -side;
            Debug.Log(currentPage);
        }
    }

    public void Update()
    {
        if (pageTurning > 0)
        {
            ui.transform.position += new Vector3(10 * side, 0, 0);
            pageTurning--;
        }
    }
}
