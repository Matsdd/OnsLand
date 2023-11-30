using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FunFactScript : MonoBehaviour
{
    public TMP_Text txt;
    public void setText()
    {
        var rand = Mathf.Round(Random.Range(1,10));

        if (rand == 1)
        {
            txt.text = "Fun Fact: \nHet perceel in Wassenaar maakt hun eigen jammetjes van verse stukken fruit van hun grond.";
        }
        else if (rand == 2)
        {
            txt.text = "Fun Fact: \nLand van Ons gebruikt wespen tegen al het ongedierte op hun gewassen, dit is veel beter voor de biodiversiteit.";
        }
        else if (rand == 3)
        {
            txt.text = "Fun Fact: \nHet perceel in Wassenaar is van plan hun eigen theetuintje te maken, zo kan jij dus binnenkort je eigen kruiden plukken voor je kopje thee.";
        }
        else if (rand == 4)
        {
            txt.text = "Fun Fact: \nLand van Ons heeft op elk perceel een bepaalde boer staan die alles verbouwt, lijkt jou dit nou ook leuk check dan de Land van Ons website.";
        }
        else if (rand == 5)
        {
            txt.text = "Fun Fact: \n Land van ons verkoopt en verbouwt niet alleen eten, maar maken ook hun eigen bier, check de Land van Ons website voor meer hierover.";
        }
        else if (rand == 6)
        {
            txt.text = "Appel";
        }
        else if (rand == 7)
        {
            txt.text = "Cranberry";
        }
        else if (rand == 8)
        {
            txt.text = "Augurk";
        }
        else if (rand == 9)
        {
            txt.text = "Tomaat";
        }
        else if (rand == 10)
        {
            txt.text = "Ham";
        }

    }
}
