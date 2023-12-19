using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CropScript : MonoBehaviour
{
    public Animator anim;
    public GameObject thing;
    public GameObject crop;

    public GameObject waterBar;

    public float growthTimer = 0f;
    public float growth;
    
    void Start()
    {
        anim.SetTrigger("GrowTrigger");
    }

    
    void Update()
    {
        growth = (0.75f * BarsScript.fillAmntG) + (0.75f * BarsScript.fillAmntW);
        growthTimer += growth;
        Debug.Log(growthTimer);
    }

    private void OnMouseDown()
    {
        if (growthTimer >= 10000)
        {
            Destroy(thing);
            crop.GetComponent<PlantScript>().booked = false;
            InventoryScript.buckwheat++;
        }
    }
}
