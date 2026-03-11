using UnityEngine;

public class CardSO : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public Sprite cardSprite;
    public enum CardType
    {
        Nuetral,
        Positive,
        Negative
    }
    public virtual void CardEvent()
    {

    }
}
