using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringScript : MonoBehaviour
{
    public float water;
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
        water = 1;
    }
}
