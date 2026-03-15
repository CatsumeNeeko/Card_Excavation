using UnityEngine;
[CreateAssetMenu(menuName = "CardEffects/Currency")]
public class CurrencyCard : CardSO
{
    public int ammount;
    public bool isGained;
    public bool isDept;

    public override void CardEvent()
    {
        Debug.Log("Currency card drawn");
        if (isGained)//This is for the player to gain currency
        {
            Debug.Log("Gain currency : True");
            GameManager.Instance.currencyManager.GainCurrency(ammount);
        }
        else//This is for the player to lose currency
        {
            Debug.Log("Gain currency : False");

        }


        base.CardEvent();
    }
}
