using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemoveSignScript : MonoBehaviour
{
    public GameObject SignField;
    public GameObject Field;
    public Vector3 vec;
    public Vector3 uivec;
    public Quaternion quat;
    public static float fieldsUnlocked = 0;
    public float cost = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        cost = fieldsUnlocked * fieldsUnlocked * 10 + 5;
        if (InventoryScript.cash > cost && WelcomeScript.welcomed)
        {
            DestroyImmediate(this.SignField, true);
            GameObject fild = Instantiate(Field, vec, quat);

            fild.SendMessage("TheStart", vec);
            fild.SendMessage("TheStart2", uivec);

            InventoryScript.cash -= cost;
            fieldsUnlocked++;
        }
    }
}
