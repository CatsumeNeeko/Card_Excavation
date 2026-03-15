using System.Collections.Generic;
using UnityEngine;

public class SearchCardsSo : ScriptableObject
{
    public string searchName;
    public string searchDescription;
    public int searchValue;
    public Sprite searchSprite;
    public List<CardType> searchType;

    public virtual void SearchCardEvent() { }


}
