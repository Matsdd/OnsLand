using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public static float cash = 10;

    public static float buckwheatSeeds = 3;
    public static float buckwheat = 0;

    public static float wheatSeeds = 0;
    public static float wheat = 0;

    public static float oatSeeds = 0;
    public static float oat = 0;

    public static float speltSeeds = 0;
    public static float spelt = 0;

    public static float ryeSeeds = 0;
    public static float rye = 0;

    public static float appleSeeds = 0;
    public static float apple = 0;

    public static float hopSeeds = 0;
    public static float hop = 0;

    public static float cranberrySeeds = 0;
    public static float cranberry = 0;

    public static float huttentutSeeds = 0;
    public static float huttentut = 0;

    public static TMP_Text buckwheatText;
    public static TMP_Text wheatText;
    public static TMP_Text oatText;

    void Start()
    {
        buckwheatText = GameObject.Find("BuckwheatText").GetComponent<TMP_Text>();
        wheatText = GameObject.Find("WheatText").GetComponent<TMP_Text>();
        oatText = GameObject.Find("OatText").GetComponent<TMP_Text>();
    }

    void Update()
    {
        
    }
}
