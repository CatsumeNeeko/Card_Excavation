using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "SearchCards/BaseSearch")]
public class BasicSearchCard : SearchCardsSo
{
    public override void SearchCardEvent()
    {
        GameManager gameManager = GameManager.Instance;
        gameManager.deckManager.searchDeck.Clear();
        Debug.Log("button press");
        int searchcount = 0;
        for (int i = 0; i < searchValue; i++)
        {
            gameManager.deckManager.searchDeck.Add(gameManager.deckManager.activeDeck[i]);
        }
        foreach (var deckToSearch in gameManager.deckManager.searchDeck)
        {
            if (searchType.Contains(deckToSearch.cardType))
            {
                searchcount++;
                Debug.Log("Search count increse : " + searchcount);
            }
        }
        Debug.Log("Final Search Count : " + searchcount);
    }
}
