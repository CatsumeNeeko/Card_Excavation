using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{
    // Things to do in this
    // On turn start draw
    // On draw with checks if deck is empty 
    // Change the search deck to the Search card 
    private GameManager gameManager;
    public List<SearchCard> searchCardHand;
    public List<SearchCard> searchCardDrawPile;
    public List<SearchCard> searchCardDiscardPile;
    public List<SearchCard> searchCardDestroyedPile;
    public int maxHandSize = 10;
    void Awake()
    {
        gameManager = GetComponent<GameManager>();
    }

    public void EndTurnDraw(int _drawAmmount)
    {
        //If you can draw all the cards
        if (searchCardDrawPile.Count >= _drawAmmount)
        {
            for (int i = 0; i < _drawAmmount; i++)
            {
                if (searchCardHand.Count < maxHandSize)
                {
                    //Show Discard Card here if you want to
                    searchCardDiscardPile.Add(searchCardDrawPile[0]);
                    searchCardDrawPile.Remove(searchCardDrawPile[0]);
                }
                else
                {
                    searchCardHand.Add(searchCardDrawPile[0]);
                    searchCardDrawPile.Remove(searchCardDrawPile[0]);
                }
            }
        }
        else if (searchCardDrawPile.Count < _drawAmmount)
        {
            int excessDraw = _drawAmmount - searchCardDrawPile.Count;

            for (int i = 0; i < searchCardDrawPile.Count; i++)
            {


                gameManager.deckManager.ShuffleSearchDeck();
            }
            for (int i = 0; i < excessDraw; i++)
            {

            }
        }
    }
    public void DrawCards(int _drawAmmount)
    {

    }

    public void Playcard()
    {
        searchCardDiscardPile.Add(searchCardHand[0]);
        searchCardHand.Remove(searchCardHand[0]);
    }
}
