using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CropScript : MonoBehaviour
{
    public Animator anim;
    public GameObject thing;
    public GameObject crop;

    public GameObject waterBar;
    public GameObject theBugs;

    public float growthTimer = 0f;
    public float growth;

    public float bugRandom = 1f;
    public Vector3 vec;
    public Quaternion quat;

    public bool infested = false;
    public static float bugFreePlots = 5;
    public GameObject bugies;
    public float infestationChance;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (!infested) {
            growth = (0.75f * BarsScript.fillAmntG) + (0.75f * BarsScript.fillAmntW);
            growthTimer += growth;
        }

        if (!infested && growthTimer < 10000)
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
    }

    private void OnMouseDown()
    {
        if (infested)
        {
            Destroy(bugies);
            infested = false;
            bugFreePlots++;
        }
        if (growthTimer >= 10000)
        {
            Destroy(thing);
            crop.GetComponent<PlantScript>().booked = false;
            InventoryScript.buckwheat++;
        }
    }
}
