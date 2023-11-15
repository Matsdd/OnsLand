using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherScript : MonoBehaviour
{
    public ParticleSystem itsRainingMen;
    public float rainRandom = 0f;
    public float rainTime = 0f;

    void Update()
    {
        Debug.Log(rainTime);
        rainTime--;

        if (rainTime > 0)
        {
            itsRainingMen.Emit(1);
        }
        else
        {
            rainRandom = Mathf.Round(Random.Range(0, 10000));
        }

        if (rainRandom == 0)
        {
            rainTime = Random.Range(4000, 10000);
            rainRandom = 1;
        }
    }
}