using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherScript : MonoBehaviour
{
    public ParticleSystem itsRainingMen;
    public float rainRandom = 0f;
    public float rainTime = 0f;

    public static bool raining = false;
    public static float temp = 20;

    void Update()
    {
        Debug.Log(rainTime);
        rainTime--;
        Debug.Log(rainTime);

        if (rainTime > 0)
        {
            itsRainingMen.Emit(1);
            raining = true;
        }
        else
        {
            rainRandom = Mathf.Round(Random.Range(0, 40000));
            raining = false;
        }

        if (rainRandom == 0)
        {
            rainTime = Random.Range(4000, 10000);
            rainRandom = 1;
        }
    }
}