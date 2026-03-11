using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    [Header("Getting Deck info")]
    public DeckSO deckSO;
    private List<CardSO> cardID;
    private List<int> deckAmount;
    public Dictionary<CardSO, int> deckDictionary = new Dictionary<CardSO, int>();
    [Header("Active Deck Info")]
    public List<CardSO> activeDeck;
    private GameObject activeCard;//This will be public later
    [Header("Search Deck info")]
    public List<CardSO> searchDeck;
    private void Awake()
    {
        GenerateGettingDeck();
        GenerateActiveDeck();
    }

    void GenerateGettingDeck()
    {
        //Getting the lists from the SO
        cardID = deckSO.cardID;
        deckAmount = deckSO.deckAmmount;

        //Copying the lists into a dictionary
        if (cardID.Count != deckAmount.Count)
        {
            Debug.LogError("The lists are not the same length!");
            return;
        }
        for (int i = 0; i < cardID.Count; i++)
        {
            CardSO card = cardID[i];
            int amount = deckAmount[i];

            if (!deckDictionary.ContainsKey(card))//Duplicate card check(you can use the same SO script but not the same asset)
            {
                deckDictionary.Add(card, amount);
            }
            else
            {
                Debug.LogWarning("Duplicate card: " + card.name);
            }
        }
        //This is to print out the deckDictionary normally you can have this commented out
        // foreach (var entry in deckDictionary)
        // {
        //     Debug.Log(entry.Key.name + " : " + entry.Value);
        // }
    }
    void GenerateActiveDeck()
    {
        activeDeck.Clear();
        foreach (var info in deckDictionary)
        {
            CardSO card = info.Key;
            int amount = info.Value;

            for (int i = 0; i < amount; i++)
            {
                activeDeck.Add(card);
            }
        }
        RandomizeDeck();
    }
    void RandomizeDeck()
    {
        for (int i = 0; i < activeDeck.Count; i++)
        {
            int randomIndex = Random.Range(i, activeDeck.Count);

            CardSO temp = activeDeck[i];
            activeDeck[i] = activeDeck[randomIndex];
            activeDeck[randomIndex] = temp;
        }
    }
}
