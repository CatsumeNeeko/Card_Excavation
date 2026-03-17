using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    //This is for the drawing deck
    [Header("Draw Deck:Getting Deck info")]
    public DeckSO deckSO;
    private List<CardSO> cardID;
    private List<int> deckAmount;
    public Dictionary<CardSO, int> deckDictionary = new Dictionary<CardSO, int>();
    [Header("Search Deck:Active Deck Info")]
    public List<CardSO> activeDeck;
    private GameObject activeCard;//This will be public later
    [Header("Search Deck: Getting Deck Info")]
    public SearchDeckSO searchDeckSO;
    private List<SearchCardsSo> searchCardID;
    private List<int> searchDeckAmount;
    public Dictionary<SearchCardsSo, int> searchDeckDictionary = new Dictionary<SearchCardsSo, int>();
    [Header("Search Deck: Active Deck Info")]
    public List<SearchCardsSo> searchDeckHand;
    public List<SearchCardsSo> searchDeckDraw;
    public List<SearchCardsSo> searchDeckDiscard;

    private int handDrawSize = 5;
    private int handSize = 10;
    [Header("Search Deck info (Used in search deck cards)")]
    public List<CardSO> searchDeck;
    private void Awake()
    {
        GenerateDrawDeck();
        GenerateSearchDeck();
    }
    #region Generating Decks
    #region Generate Deck
    void GenerateDrawDeck()
    {
        //This is for the drawing Deck
        //Getting the lists from the SO
        cardID = deckSO.cardID;
        deckAmount = deckSO.deckAmmount;

        //Copying the lists into a dictionary
        if (cardID.Count != deckAmount.Count)
        {
            Debug.LogError("Draw Deck: The lists are not the same length!");
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
        GenerateActiveDrawDeck();
    }
    void GenerateSearchDeck()
    {
        searchCardID = searchDeckSO.searchCardID;
        searchDeckAmount = searchDeckSO.searchDeckAmonut;

        if (searchCardID.Count != searchDeckAmount.Count)
        {
            Debug.LogError("Search Deck:The lists are not the same length!");
            return;
        }
        for (int i = 0; i < searchCardID.Count; i++)
        {
            SearchCardsSo card = searchCardID[i];
            int amount = searchDeckAmount[i];
            if (!searchDeckDictionary.ContainsKey(card))
            {
                searchDeckDictionary.Add(card, amount);
            }
            else
            {
                Debug.LogWarning("Duplicate card: " + card.name);
            }
        }
        GenerateActiveSearchDeck();
    }
    #endregion
    #region Generate Active Deck
    void GenerateActiveDrawDeck()
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
        RandomizeDrawDeck();
    }
    void GenerateActiveSearchDeck()
    {
        searchDeckDraw.Clear();
        foreach (var info in searchDeckDictionary)
        {
            SearchCardsSo card = info.Key;
            int amount = info.Value;

            for (int i = 0; i < amount; i++)
            {
                searchDeckDraw.Add(card);
            }
        }
        RandomizeSearchDeck();
    }
    #endregion
    #region  Randomize Deck
    void RandomizeDrawDeck()
    {
        for (int i = 0; i < activeDeck.Count; i++)
        {
            int randomIndex = Random.Range(i, activeDeck.Count);

            CardSO temp = activeDeck[i];
            activeDeck[i] = activeDeck[randomIndex];
            activeDeck[randomIndex] = temp;
        }
    }
    void RandomizeSearchDeck()
    {
        for (int i = 0; i < searchDeckDraw.Count; i++)
        {
            int randomIndex = Random.Range(i, searchDeckDraw.Count);
            SearchCardsSo temp = searchDeckDraw[i];
            searchDeckDraw[i] = searchDeckDraw[randomIndex];
            searchDeckDraw[randomIndex] = temp;
        }
    }
    #endregion
    #endregion
    public void DrawSearchHand()
    {
        //IF not check if draw is == 0 is true shuffle deck then draw 
        //IF not draw the ammount that is avaliable and then shuffle then draw whatever the excess is 
        if (searchDeckDraw.Count >= handDrawSize)///IF draw deck has more then draw size
        {
            for (int i = 0; i < handDrawSize; i++)
            {
                searchDeckHand.Add(searchDeckDraw[0]);
                searchDeckDraw.Remove(searchDeckDraw[0]);
            }
        }
        else if (searchDeckDraw.Count < handDrawSize)
        {
            int excessDraw = handDrawSize - searchDeckDraw.Count;

            for (int i = 0; i < searchDeckDraw.Count; i++)
            {
                searchDeckHand.Add(searchDeckDraw[0]);
                searchDeckDraw.Remove(searchDeckDraw[0]);
            }
            for (int i = 0; i < excessDraw; i++)
            {
                searchDeckHand.Add(searchDeckDraw[0]);
                searchDeckDraw.Remove(searchDeckDraw[0]);
            }
        }
    }

    public void DrawDeckCard()
    {

    }
}
