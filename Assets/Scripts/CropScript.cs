using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

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

    public GameObject feedbacktxtmanager;
    public float feedbackTxtTime = 0;

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
    public static bool ablePause = true;

    public float randomCropAmnt;
    public float randomSeedAmnt;

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
                growth = (10f * BarsScript.fillAmntG * BarsScript.fillAmntW) * growthMultiplier;
                growthTimer += growth;
            }

            if (!infested && stage < 3)
            {
                infestationChance = bugFreePlots * 1000;
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
        if (gameRunning)
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
                    randomCropAmnt = Mathf.Round(Random.Range(1, 2.7f));
                    InventoryScript.buckwheat += randomCropAmnt;
                    randomSeedAmnt = Mathf.Round(Random.Range(0.28f, 1.82f));
                    InventoryScript.buckwheatSeeds += randomSeedAmnt;
                    HarvestFeedbackManager.textString = "+" + randomCropAmnt + " Boekweit\n+" + randomSeedAmnt + " Zaadjes";
                }
                else if (kind == "Wheat")
                {
                    randomCropAmnt = Mathf.Round(Random.Range(1, 2.9f));
                    InventoryScript.wheat += randomCropAmnt;
                    randomSeedAmnt = Mathf.Round(Random.Range(0.3f, 1.76f));
                    InventoryScript.wheatSeeds += randomSeedAmnt;
                    HarvestFeedbackManager.textString = "+" + randomCropAmnt + " tarwe\n+" + randomSeedAmnt + " Zaadjes";
                }
                else if (kind == "Rye")
                {
                    randomCropAmnt = Mathf.Round(Random.Range(0.8f, 2.75f));
                    InventoryScript.rye += randomCropAmnt;
                    randomSeedAmnt = Mathf.Round(Random.Range(0.3f, 1.69f));
                    InventoryScript.ryeSeeds += randomSeedAmnt;
                    HarvestFeedbackManager.textString = "+" + randomCropAmnt + " rogge\n+" + randomSeedAmnt + " Zaadjes";
                }
                else if (kind == "Oat")
                {
                    randomCropAmnt = Mathf.Round(Random.Range(0.8f, 2.7f));
                    InventoryScript.oat += randomCropAmnt;
                    randomSeedAmnt = Mathf.Round(Random.Range(0.3f, 1.72f));
                    InventoryScript.oatSeeds += randomSeedAmnt;
                    HarvestFeedbackManager.textString = "+" + randomCropAmnt + " haver\n+" + randomSeedAmnt + " Zaadjes";
                }
                else if (kind == "Spelt")
                {
                    randomCropAmnt = Mathf.Round(Random.Range(0.9f, 2.8f));
                    InventoryScript.spelt += randomCropAmnt;
                    randomSeedAmnt = Mathf.Round(Random.Range(0.3f, 1.74f));
                    InventoryScript.speltSeeds += randomSeedAmnt;
                    HarvestFeedbackManager.textString = "+" + randomCropAmnt + " spelt\n+" + randomSeedAmnt + " Zaadjes";
                }
                else if (kind == "Hop")
                {
                    randomCropAmnt = Mathf.Round(Random.Range(1f, 2f));
                    InventoryScript.hop += randomCropAmnt;
                    randomSeedAmnt = Mathf.Round(Random.Range(0.4f, 1.2f));
                    InventoryScript.hopSeeds += randomSeedAmnt;
                    HarvestFeedbackManager.textString = "+" + randomCropAmnt + " hop\n+" + randomSeedAmnt + " Zaadjes";
                }
                else if (kind == "Hut")
                {
                    randomCropAmnt = Mathf.Round(Random.Range(0.9f, 2));
                    InventoryScript.huttentut += randomCropAmnt;
                    randomSeedAmnt = Mathf.Round(Random.Range(0.35f, 1.82f));
                    InventoryScript.huttentutSeeds += randomSeedAmnt;
                    HarvestFeedbackManager.textString = "+" + randomCropAmnt + " huttentut\n+" + randomSeedAmnt + " Zaadjes";
                }
                else if (kind == "Cran")
                {
                    randomCropAmnt = Mathf.Round(Random.Range(1.1f, 3.7f));
                    InventoryScript.cranberry += randomCropAmnt;
                    randomSeedAmnt = Mathf.Round(Random.Range(1, 1.8f));
                    InventoryScript.cranberrySeeds += randomSeedAmnt;
                    HarvestFeedbackManager.textString = "+" + randomCropAmnt + " cranberry\n+" + randomSeedAmnt + " Zaadjes";
                }
                else if (kind == "Apple")
                {
                    randomCropAmnt = Mathf.Round(Random.Range(0.9f, 2.7f));
                    InventoryScript.apple += randomCropAmnt;
                    randomSeedAmnt = Mathf.Round(Random.Range(1, 1.7f));
                    InventoryScript.appleSeeds += randomSeedAmnt;
                    HarvestFeedbackManager.textString = "+"+randomCropAmnt+ " Appel\n+" + randomSeedAmnt + " Zaadjes";
                }
                HarvestFeedbackManager.activate = true;
            }
        }
    }
}
