using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class SearchCard : MonoBehaviour
{
    public SearchCardsSo searchCardsSo;
    private SpriteRenderer spriteRenderer;


    public void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = searchCardsSo.searchSprite;
    }

}
