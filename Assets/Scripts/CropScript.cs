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

    public float stage = 1;

    public string kind;
    //boekweit heeft een mulitplier van 1
    public float growthMultiplier = 1;
    
    public void TheStart(string fl)
    {
        kind = fl;
        if (kind == "Wheat")
        {
            growthMultiplier = 0.86f;
        }
    }

    
    void Update()
    {
        if (!infested && BarsScript.fillAmntW > 0 && BarsScript.fillAmntG > 0) {
            growth = (0.75f * BarsScript.fillAmntG) + (0.75f * BarsScript.fillAmntW) * growthMultiplier;
            growthTimer += growth;
        }

        if (!infested && stage < 3)
        {
            infestationChance = bugFreePlots * 1800;
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
                InventoryScript.buckwheatSeeds += Mathf.Round(Random.Range(0.24f, 1.82f));
            }else if (kind == "Wheat")
            {
                InventoryScript.wheat += Mathf.Round(Random.Range(1, 2.9f));
                InventoryScript.wheatSeeds += Mathf.Round(Random.Range(0.1f, 1.76f));
            }
        }
    }
}
