using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropScript : MonoBehaviour
{
    public GameObject crops;
    public Vector3 vec;
    public Quaternion quat;
    public GameObject well;
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
        Instantiate(crops, vec, quat);
    }
}