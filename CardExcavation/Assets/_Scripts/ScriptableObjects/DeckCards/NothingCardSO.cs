using UnityEngine;
[CreateAssetMenu(menuName = "CardEffects/Nothing")]//[CreateAssetMenu(menuName = "CardEffects/")]
public class NothingCardSO : CardSO
{
    public override void CardEvent()
    {
        Debug.Log("This card does nothing");
        base.CardEvent();
    }
}
