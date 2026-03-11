using UnityEngine;

public class CurrencyManager : MonoBehaviour
{
    public int currency;

    public void GainCurrency(int ammount)
    {
        currency += ammount;
    }
    public void LoseCurrency(int ammount, bool debt)
    {
        if (!debt)
        {
            currency -= ammount;
            if (currency < 0)
                currency = 0;
        }
        else
        {
            currency -= ammount;
        }
    }
    public void SpendCurrency(int itemCost)
    {
        if (currency < itemCost)
        {
            Debug.Log("Item is to expensive!");
        }
        else if (currency >= itemCost)
        {
            currency -= itemCost;
            Debug.Log("You have purchased an item for: " + itemCost);
        }
    }
}
