using UnityEngine;
[RequireComponent(typeof(CurrencyManager))]
[RequireComponent(typeof(DeckManager))]
[RequireComponent(typeof(ItemManager))]
[RequireComponent(typeof(InputManager))]
[RequireComponent(typeof(HandManager))]
public class GameManager : MonoBehaviour
{
    [Header("Classes")]
    public static GameManager Instance;
    public CurrencyManager currencyManager;
    public DeckManager deckManager;
    public ItemManager itemManager;
    public InputManager inputManager;
    public HandManager handManager;

    public float timeLeft;
    private void Awake()
    {
        Instance = this;
        currencyManager = GetComponent<CurrencyManager>();
        inputManager = GetComponent<InputManager>();
        deckManager = GetComponent<DeckManager>();
        itemManager = GetComponent<ItemManager>();
        handManager = GetComponent<HandManager>();
        timeLeft = 30f;
    }

    void Update()
    {
        timeLeft = timeLeft - Time.deltaTime;
    }
}
