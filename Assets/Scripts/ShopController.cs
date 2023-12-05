using UnityEngine;
using TMPro;

public class ShopController : MonoBehaviour
{
    public TMP_Text currencyText;

    void Start()
    {
        UpdateCurrencyText();
    }

    public void BuyItem(int itemCost)
    {
        // Access cash directly from the InventoryScript
        if (InventoryScript.cash >= itemCost)
        {
            InventoryScript.cash -= itemCost;
            UpdateCurrencyText();
            Debug.Log("BuyItem clicked!");
        }
        else
        {
            Debug.LogError("Not enough money to buy the item!");
        }
    }

    public void SellItem()
    {
        // Modify cash directly from the InventoryScript
        InventoryScript.cash += 10;
        UpdateCurrencyText();
        Debug.Log("SellItem clicked!");
    }

    public void appel()
    {
        BuyItem(8);
        UpdateCurrencyText();
        Debug.Log("SellItem clicked!");
    }

    public void boekweit()
    {
        BuyItem(18);
        UpdateCurrencyText();
    }

    void UpdateCurrencyText()
    {
        // Access cash directly from the InventoryScript
        currencyText.text = "Currency: " + InventoryScript.cash;
    }
}
