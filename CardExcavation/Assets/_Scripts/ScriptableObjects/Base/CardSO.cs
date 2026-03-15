using UnityEngine;
public enum CardType
{
    Neutral,
    Positive,
    Negative,
    Death
}
public class CardSO : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public Sprite cardSprite;
    public CardType cardType;
    public virtual void CardEvent()
    {

    }
}
