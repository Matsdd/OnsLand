using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScript : MonoBehaviour
{
    public GameObject crops;
    public GameObject Field;
    public Vector3 vec;
    public Quaternion quat;
    public GameObject well;

    // Start is called before the first frame update
    void TheStart(Vector3 vec)
    {
        transform.position = vec;

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        Instantiate(crops, vec, quat);
        Debug.Log(vec);
    }
}