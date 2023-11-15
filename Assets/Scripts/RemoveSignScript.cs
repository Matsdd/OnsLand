using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveSignScript : MonoBehaviour
{
    public GameObject SignField;
    public GameObject Field;
    public Vector3 vec;
    public Quaternion quat;
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
        DestroyImmediate(this.SignField, true);
        Instantiate(Field, vec, quat);
    }
}
