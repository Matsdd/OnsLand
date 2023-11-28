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
            txt.text = "Kaas";
        }
        else if (rand == 2)
        {
            txt.text = "Bij";
        }
        else if (rand == 3)
        {
            txt.text = "Koe";
        }
        else if (rand == 4)
        {
            txt.text = "Kip";
        }
        else if (rand == 5)
        {
            txt.text = "Peer";
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
