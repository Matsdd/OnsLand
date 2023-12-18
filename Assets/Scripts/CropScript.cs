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
    
    void Start()
    {
        anim.SetTrigger("GrowTrigger");
    }

    
    void Update()
    {
        growthTimer += 1;
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
