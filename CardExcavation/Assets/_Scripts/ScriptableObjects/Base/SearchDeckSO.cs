using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Deck/Search")]
public class SearchDeckSO : ScriptableObject
{
    public List<SearchCardsSo> searchCardID;
    public List<int> searchDeckAmonut;
}
