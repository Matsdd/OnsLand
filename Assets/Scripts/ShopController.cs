using UnityEngine;
using TMPro;

public class ShopController : MonoBehaviour
{
    public TMP_Text currencyText;

    void Start()
    {
        UpdateCurrencyText();
    }

    public void BuyItem(int itemCost, float item)
    {
        if (InventoryScript.cash >= itemCost)
        {
            InventoryScript.cash -= itemCost;
            addItem(item);

            UpdateCurrencyText();
            Debug.Log(InventoryScript.buckwheatSeeds);
        }
    }

    public void addItem(float item)
    {
        if (item == 1)
        {
            InventoryScript.appleSeeds++;
        }else if (item == 2)
        {
            InventoryScript.buckwheatSeeds++;
        }
        else if (item == 3)
        {
            InventoryScript.huttentutSeeds++;
        }
        else if (item == 4)
        {
            InventoryScript.wheatSeeds++;
        }
        else if (item == 5)
        {
            InventoryScript.speltSeeds++;
        }
        else if (item == 6)
        {
            InventoryScript.hopSeeds++;
        }
        else if (item == 7)
        {
            InventoryScript.cranberrySeeds++;
        }
    }


    public void SellItem()
    {
        InventoryScript.cash += 10;
        UpdateCurrencyText();
    }

    public void Appel()
    {
        BuyItem(40, 1);
    }
    public void Boekweit()
    {
        BuyItem(8, 2);
    }
    public void Huttentut()
    {
        BuyItem(12, 3);
    }
    public void Tarwe()
    {
        BuyItem(18, 4);
    }
    public void Spelt()
    {
        BuyItem(20, 5);
    }
    public void Hop()
    {
        BuyItem(30, 6);
    }
    public void Cranberry()
    {
        BuyItem(50, 7);
    }

    void UpdateCurrencyText()
    {
        if (InventoryScript.cash < 9999)
        {
            currencyText.text = "Cash = " + InventoryScript.cash;
        }
        else
        {
            currencyText.text = "Cash = 9999";
        }
    }
}
