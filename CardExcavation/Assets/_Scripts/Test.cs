using UnityEngine;
using UnityEngine.InputSystem;
public class Test : MonoBehaviour
{
    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log(context.ReadValue<Vector2>());
    }
}
