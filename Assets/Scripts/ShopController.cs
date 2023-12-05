using UnityEngine;
using TMPro;

public class ShopController : MonoBehaviour
{
    public TMP_Text currencyText;
    public TMP_Text errorMessageText;
    public TMP_Text successMessageText;
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
        // Access cash directly from the InventoryScript
        if (InventoryScript.cash >= itemCost)
        {
            InventoryScript.cash -= itemCost;
            UpdateCurrencyText();
            DisplaySuccessMessage("succesvolle aankoop!");
            Debug.Log("BuyItem clicked!");
        }
        else
        {
            DisplayErrorMessage("Niet genoeg cash!");
        }
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
        // Set the error message text and make it visible
        errorMessageText.text = message;
        errorMessageText.gameObject.SetActive(true);

        // Hide the error message after a specified time
        Invoke("HideErrorMessage", errorMessageDisplayTime);
    }

    void HideErrorMessage()
    {
        // Hide the error message
        errorMessageText.gameObject.SetActive(false);
    }

    void DisplaySuccessMessage(string message)
    {
        // Set the success message text and make it visible
        successMessageText.text = message;
        successMessageText.gameObject.SetActive(true);

        // Hide the success message after a specified time
        Invoke("HideSuccessMessage", successMessageDisplayTime);
    }

    void HideSuccessMessage()
    {
        // Hide the success message
        successMessageText.gameObject.SetActive(false);
    }
}
