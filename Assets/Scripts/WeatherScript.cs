using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherScript : MonoBehaviour
{
    public ParticleSystem itsRainingMen;
    public ParticleSystem itsSnowingMen;

    public float rainRandom = 0f;
    public float rainDuration = 0f;
    public float snowRandom = 1f;
    public float snowDuration = 1f;

    public static bool raining = false;
    public static bool snowing = false;
    public static bool harshSun = false;

    public static float temp = 20;

    void Update()
    {
        //rain
        rainDuration--;

        if (rainDuration > 0) {
            itsRainingMen.Emit(1);
            raining = true;
        } else if (snowDuration <= 0) {
            //gaat het regenen?
            rainRandom = Mathf.Round(Random.Range(0, 40000));
            raining = false;
        }

        if (rainRandom == 0)
        {
            //hoelang gaat het regenen?
            rainDuration = Random.Range(4000, 10000);
            rainRandom = 1;
        }

        //snow
        snowDuration--;

        if (snowDuration > 0) {
            itsSnowingMen.Emit(1);
            snowing = true;
        } else if (rainDuration <= 0) {
            //gaat het sneeuwen?
            snowRandom = Mathf.Round(Random.Range(0, 65000));
            snowing = false;
        }

        if (snowRandom == 0)
        {
            //hoelang sneeuwt het?
            snowDuration = Random.Range(4000, 15000);
            snowRandom = 1;
        }
    }
}