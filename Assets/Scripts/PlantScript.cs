using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScript : MonoBehaviour
{
    public GameObject Field;
    public Vector3 vect;
    public Quaternion quat;
    public bool positionSet = false;
    public bool booked = false;

    public GameObject cropUI;
    public GameObject ui;
    public Vector3 uivect;
    public Quaternion uiquat;
    public static bool cropSelecting = false;

    // Start is called before the first frame update
    void TheStart(Vector3 vec)
    {
        //transform.position = vec;
        vect = vec;
    }
    void TheStart2(Vector3 uivec)
    {
        //transform.position = vec;
        uivect = uivec;
    }

    // Update is called once per frame
    void Update()
    {
        if (!booked)
        {
            if (WeatherScript.snowing)
            {
                BarsScript.fillAmntG += 0.000012f;
            }
            else
            {
                BarsScript.fillAmntG += 0.00002f;
            }
        }
    }

    private void OnMouseDown()
    {
        if (!positionSet)
        {
            vect.x += -1.7f;
            vect.y += 1f;
            vect.z -= -2f;
            positionSet = true;
        }
        if (!cropSelecting)
        {

                GameObject Ui = Instantiate(ui, uivect, uiquat);
                Ui.SendMessage("TheStart", vect);

                booked = true;
                Debug.Log(booked);

                cropSelecting = true;
           
        }
    }
}