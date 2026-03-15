using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    public bool shopOpen;
    public bool inventoryOpen;

    private void Awake()
    {
        shopOpen = false;
        inventoryOpen = false;
    }
    void OnEnable()
    {
    }


    public void OnClick(InputAction.CallbackContext context)
    {

    }
    public void OnShop(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            shopOpen = !shopOpen;
            inventoryOpen = false;
            Debug.Log("Shop toggled: " + shopOpen);
        }
    }
    public void OnInventory(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            inventoryOpen = !inventoryOpen;
            shopOpen = false;
            Debug.Log("Inventory toggled: " + inventoryOpen);
        }
    }
}
