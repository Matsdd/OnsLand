using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropScript : MonoBehaviour
{
    public Animator anim;
    public GameObject thing;
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

        Destroy(thing);
    }
}
