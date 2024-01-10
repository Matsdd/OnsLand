using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CropScript : MonoBehaviour
{
    public Animator anim;
    //self
    public GameObject thing;
    //graphics
    public GameObject crop;
    public GameObject stage2;
    public GameObject stage3;
    public GameObject theBugs;

    public float growthTimer = 0f;
    public float growth;

    public float bugRandom = 1f;
    public Vector3 vec;
    public Vector3 vecs1;
    public Quaternion quat;

    public bool infested = false;
    public static float bugFreePlots = 5;
    public GameObject bugies;
    public float infestationChance;
    public float infestationTimer = 0;

    public float stage = 1;

    public string kind;
    //boekweit heeft een mulitplier van 1
    public float growthMultiplier = 1;

    public static bool gameRunning = true;

    public void TheStart(string fl)
    {
        kind = fl;
        if (kind == "Wheat" || kind == "Rye" || kind == "Oat" || kind == "Spelt")
        {
            growthMultiplier = 0.86f;
        } else if (kind == "Cran" || kind == "Apple")
        {
            growthMultiplier = 0.62f;
        } else if (kind == "Hop")
        {
            growthMultiplier = 0.72f;
        } else if (kind == "Hut")
        {
            growthMultiplier = 0.92f;
        }
    }

    
    void Update()
    {
        if (gameRunning)
        {
            if (infested)
            {
                infestationTimer++;
            }
            if (infestationTimer > 10000)
            {
                Destroy(thing);
                Destroy(bugies);
                bugFreePlots++;
            }

            if (!infested && BarsScript.fillAmntW > 0 && BarsScript.fillAmntG > 0)
            {
                growth = (1.5f * BarsScript.fillAmntG * BarsScript.fillAmntW) * growthMultiplier;
                growthTimer += growth;
            }

            if (!infested && stage < 3)
            {
                infestationChance = bugFreePlots * 1900;
                bugRandom = Mathf.Round(Random.Range(0, infestationChance));
                if (bugRandom == 0)
                {
                    vec = thing.transform.position;
                    vec.x += 1.7f;
                    vec.y -= 1;

                    bugies = Instantiate(theBugs, vec, quat);

                    infested = true;
                    bugFreePlots--;
                }
            }
        }

        if (growthTimer >= 10000 && stage == 1)
        {
            Destroy(crop);
            vecs1 = thing.transform.position;
            crop = Instantiate(stage2, vecs1, quat);
            crop.transform.parent = thing.transform;
            stage++;
        }
        if (growthTimer >= 20000 && stage == 2)
        {
            Destroy(crop);
            crop = Instantiate(stage3, vecs1, quat);
            crop.transform.parent = thing.transform;
            stage++;
        }
    }

    private void OnMouseDown()
    {
        if (infested)
        {
            Destroy(bugies);
            infested = false;
            bugFreePlots++;
        }
        if (stage == 3)
        {
            Destroy(thing);
            if (kind == "Buckwheat")
            {
                InventoryScript.buckwheat += Mathf.Round(Random.Range(1, 2.7f));
                InventoryScript.buckwheatSeeds += Mathf.Round(Random.Range(0.28f, 1.82f));
            }else if (kind == "Wheat")
            {
                InventoryScript.wheat += Mathf.Round(Random.Range(1, 2.9f));
                InventoryScript.wheatSeeds += Mathf.Round(Random.Range(0.3f, 1.76f));
            }
            else if (kind == "Rye")
            {
                InventoryScript.rye += Mathf.Round(Random.Range(0.8f, 2.75f));
                InventoryScript.ryeSeeds += Mathf.Round(Random.Range(0.3f, 1.69f));
            }
            else if (kind == "Oat")
            {
                InventoryScript.oat += Mathf.Round(Random.Range(0.8f, 2.7f));
                InventoryScript.oatSeeds += Mathf.Round(Random.Range(0.3f, 1.72f));
            }
            else if (kind == "Spelt")
            {
                InventoryScript.spelt += Mathf.Round(Random.Range(0.9f, 2.8f));
                InventoryScript.speltSeeds += Mathf.Round(Random.Range(0.3f, 1.74f));
            }
            else if (kind == "Hop")
            {
                InventoryScript.hop += Mathf.Round(Random.Range(1f, 2f));
                InventoryScript.hopSeeds += Mathf.Round(Random.Range(0.4f, 1.2f));
            }
            else if (kind == "Hut")
            {
                InventoryScript.huttentut += Mathf.Round(Random.Range(0.9f, 2));
                InventoryScript.huttentutSeeds += Mathf.Round(Random.Range(0.35f, 1.82f));
            }
            else if (kind == "Cran")
            {
                InventoryScript.cranberry += Mathf.Round(Random.Range(1.1f, 3.7f));
                InventoryScript.cranberrySeeds += Mathf.Round(Random.Range(1, 1.8f));
            }
            else if (kind == "Apple")
            {
                InventoryScript.apple += Mathf.Round(Random.Range(0.9f, 2.7f));
                InventoryScript.appleSeeds += Mathf.Round(Random.Range(1, 1.7f));
            }
        }
    }
}
