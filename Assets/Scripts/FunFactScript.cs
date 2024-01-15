using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FunFactScript : MonoBehaviour
{
    public TMP_Text txt;
    public void setText()
    {
        if (WelcomeScript.welcomed && CropScript.gameRunning)
        {
            var rand = Mathf.Round(Random.Range(1, 10));

            if (rand == 1)
            {
                txt.text = "Tip 2: \nAls je je gewassen eerst omtovert tot producten kan je er een stuk meer geld mee verdienen.";
            }
            else if (rand == 2)
            {
                txt.text = "Weetje 1: \nLand van Ons gebruikt wespen tegen al het ongedierte op hun gewassen, dit is veel beter voor de biodiversiteit.";
            }
            else if (rand == 3)
            {
                txt.text = "Weetje 2: \nHet perceel in Wassenaar is van plan hun eigen theetuintje te maken, zo kan jij dus binnenkort je eigen kruiden plukken voor je kopje thee.";
            }
            else if (rand == 4)
            {
                txt.text = "Weetje 3: \nLand van Ons is een coöperatie die op 30 september 2019 werd opgericht door Franke Remerie en Jaap Benschop om de biodiversiteit op landbouwgrond te vergroten.";
            }
            else if (rand == 5)
            {
                txt.text = "Weetje 4: \n Land van ons verkoopt en verbouwt niet alleen eten, maar maken ook hun eigen bier, check de Land van Ons website voor meer hierover.";
            }
            else if (rand == 6)
            {
                txt.text = "Weetje 5: \nIn 2021 eindigde 'Land van Ons' op de zevende plaats in de 'Duurzame 100' van Dagblad Trouw. Het jaar daarvoor was 'Land van Ons' al op de veertiende plaats terechtgekomen, en in 2019, het jaar van de oprichting, kwam de coöperatie binnen op de 29e plaats.";
            }
            else if (rand == 7)
            {
                txt.text = "Tip 3: \nLet goed op de balkjes hierboven, de blauwe en bruine balken beinvloeden direct hoe snel je planten zullen groeien. Hou ze dus hoog voor optimale planten groei!";
            }
            else if (rand == 8)
            {
                txt.text = "Weetje 6: \nVia de Land van Ons website kan je lid worden van de coöperatie met twee jaar lidmaatschap à € 26,- en minimaal 2m² grond à € 14,-";
            }
            else if (rand == 9)
            {
                txt.text = "Weetje 7: \nEr is ook een Land van Ons Podcast! Je kan deze beluisteren opzowel Spotify als Apple Podcasts.";
            }
            else if (rand == 10)
            {
                txt.text = "Weetje 8: \nVeel van de percelen hebben hun eigen social media accounts op bijvoorbeeld Instagram en Facebook, hierop laten ze voornamelijk de vooruitgang van deze percelen zien.";
            }
        }
        

    }
}
