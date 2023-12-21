using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public float tempRandom = 1f;

    public static float temp = 15;
    public static string month = "January";
    public static float clock = 0f;

    public Image tempImg;

    void Update()
    {
        //rain
        rainDuration--;

        if (rainDuration > 0) {
            itsRainingMen.Emit(1);
            raining = true;
        } else if (snowDuration <= 0) {
            //gaat het regenen?
            rainRandom = Mathf.Round(Random.Range(0, 12000));
            raining = false;
        }

        if (rainRandom == 0)
        {
            //hoelang gaat het regenen?
            rainRandom = Mathf.Round(Random.Range(0, 5));
            //zomer en lente weinig regen, herfst veel, winter beetje
            if (rainRandom == 1 && (month == "April" || month == "Mei" || month == "Juni" || month == "Juli" || month == "Augustus" || month == "Maart"))
            {
                rainDuration = Random.Range(2000, 10000);
                rainRandom = 1;
            }else if ((rainRandom == 1 || rainRandom == 2) && (month == "Februari" || month == "Januari" || month == "December" || month == "November"))
            {
                rainDuration = Random.Range(4000, 10000);
                rainRandom = 1;
            }else if (rainRandom > 1 && (month == "Oktober" || month == "September"))
            {
                rainDuration = Random.Range(6000, 16000);
                rainRandom = 1;
            }
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

        //temp 
        //altijd tussen -10 en 35
        tempImg.fillAmount = (temp + 15) / 50;
        if (temp >= 25)
        {
            //warm
            tempImg.color = new Color(1f, 0.2f, 0.2f);
        }
        else if (temp >= 15)
        {
            //beetje warm
            tempImg.color = new Color(1f, 0.6f, 0.45f);
        }
        else if (temp >= 0)
        {
            //koud
            tempImg.color = new Color(0.6f, 0.6f, 1f);
        }
        else
        {
            //erg koud
            tempImg.color = new Color(0.8f, 0.8f, 1f);
        }

        //veranderd de temp?
        tempRandom = Mathf.Round(Random.Range(0, 10000));
        if ((tempRandom == 1 || (harshSun && tempRandom == 2)) && (temp < 30 || (temp < 35 && harshSun)))
        {
            temp++;
        }else if ((tempRandom == 3 || (snowing && tempRandom == 4)) && (temp > -5 || (snowing && temp > -10)))
        {
            temp--;
        }

        //maanden

        //winter:nov dec jan feb Lente: apr mar mei Zomer: Jun Jul Aug Herfst: Sep Okt
        clock += 0.4f;
        if (clock <= 10000)
        {
            month = "Januari";
        }else if (clock <= 20000)
        {
            month = "Februari";
        }
        else if (clock <= 30000)
        {
            month = "Maart";
        }
        else if (clock <= 40000)
        {
            month = "April";
        }
        else if (clock <= 50000)
        {
            month = "Mei";
        }
        else if (clock <= 60000)
        {
            month = "Juni";
        }
        else if (clock <= 70000)
        {
            month = "Juli";
        }
        else if (clock <= 80000)
        {
            month = "Augustus";
        }
        else if (clock <= 90000)
        {
            month = "September";
        }
        else if (clock <= 100000)
        {
            month = "Oktober";
        }
        else if (clock <= 110000)
        {
            month = "November";
        }
        else if (clock <= 120000)
        {
            month = "December";
        }
        if (clock == 120000)
        {
            clock = 0;
        }
    }
}