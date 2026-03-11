using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Deck")]
public class DeckSO : ScriptableObject
{
    public List<CardSO> cardID;
    public List<int> deckAmmount;
}
