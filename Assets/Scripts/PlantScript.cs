using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScript : MonoBehaviour
{
    public GameObject crops;
    public GameObject Field;
    public Vector3 vect;
    public Quaternion quat;
    public GameObject well;

    // Start is called before the first frame update
    void TheStart(Vector3 vec)
    {
        //transform.position = vec;
        vect = vec;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        Debug.Log(vect);
        vect.x += 1;
        vect.y += 1.5f;
        vect.z -= 0.5f;
        Instantiate(crops, vect, quat);
    }
}