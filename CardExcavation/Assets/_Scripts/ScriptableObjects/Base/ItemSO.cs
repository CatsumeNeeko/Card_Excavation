using UnityEngine;

public class ItemSO : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public Sprite itemSprite;

    public virtual void OnPurchase() { }
    
    public virtual void OnUse() { }
}
