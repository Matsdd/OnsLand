using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropScript : MonoBehaviour
{
    public Animator anim;
    public GameObject thing;

    public GameObject waterBar;
    // Start is called before the first frame update
    void Start()
    {
        anim.SetTrigger("GrowTrigger");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        DestroyImmediate(thing, true);
        InventoryScript.buckwheat++;
    }
}
