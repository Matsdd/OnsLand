using UnityEngine;
using TMPro;

public class ShopController : MonoBehaviour
{
    public TMP_Text currencyText;
    public TMP_Text errorMessageText;
    public TMP_Text successMessageText;
    public TMP_Text buckwheatText;
    public float errorMessageDisplayTime = 2f;
    public float successMessageDisplayTime = 2f;

    void Start()
    {
        UpdateCurrencyText();
        errorMessageText.gameObject.SetActive(false);
        successMessageText.gameObject.SetActive(false);
    }

    public void BuyItem(int itemCost)
    {
        if (InventoryScript.cash >= itemCost)
        {
            InventoryScript.cash -= itemCost;

            AddItemToInventory();

            UpdateCurrencyText();
            DisplaySuccessMessage("Succesvolle aankoop!");
            Debug.Log("BuyItem clicked!");
        }
        else
        {
            DisplayErrorMessage("Niet genoeg cash!");
        }
    }


void AddItemToInventory()
{
    Debug.Log("Before incrementing buckwheat: " + InventoryScript.buckwheat);
    InventoryScript.buckwheat++;
    Debug.Log("After incrementing buckwheat: " + InventoryScript.buckwheat);

    if (buckwheatText != null)
    {
        Debug.Log("buckwheatText is not null!");
        UpdateItemQuantityUI(buckwheatText, InventoryScript.buckwheat);
    }
    else
    {
        Debug.LogError("buckwheatText is null!");
    }
}


    void UpdateItemQuantityUI(TMP_Text itemText, float quantity)
    {
        itemText.text = "Appels: " + quantity;
    }


    public void SellItem()
    {
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
        currencyText.text = "Cash = " + InventoryScript.cash;
    }

    void DisplayErrorMessage(string message)
    {
        errorMessageText.text = message;
        errorMessageText.gameObject.SetActive(true);

        Invoke("HideErrorMessage", errorMessageDisplayTime);
    }

    void HideErrorMessage()
    {
        errorMessageText.gameObject.SetActive(false);
    }

    void DisplaySuccessMessage(string message)
    {
        successMessageText.text = message;
        successMessageText.gameObject.SetActive(true);

        Invoke("HideSuccessMessage", successMessageDisplayTime);
    }

    void HideSuccessMessage()
    {
        successMessageText.gameObject.SetActive(false);
    }
}
