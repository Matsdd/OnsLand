using UnityEngine;
using TMPro;

public class ShopController : MonoBehaviour
{
    public TMP_Text currencyText;

    private int currency = 70;

    void Start()
    {
        UpdateCurrencyText();
    }

    public void BuyItem(int itemCost)
    {
        if (currency >= itemCost)
        {
            currency -= itemCost;
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
        currency += 10;
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
        currencyText.text = "Currency: " + currency;
    }
}
