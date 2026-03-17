using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Classes")]
    public static GameManager Instance;
    public CurrencyManager currencyManager;
    public DeckManager deckManager;
    public ItemManager itemManager;
    public InputManager inputManager;

    public float timeLeft;
    private void Awake()
    {
        Instance = this;
        currencyManager = GetComponent<CurrencyManager>();
        inputManager = GetComponent<InputManager>();
        deckManager = GetComponent<DeckManager>();
        itemManager = GetComponent<ItemManager>();
    }
}
