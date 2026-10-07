using UnityEngine;
using UnityEngine.InputSystem;
public class MenuControl : MonoBehaviour
{
    [SerializeField] private TextView menu;
    [SerializeField] private InputActionProperty input;
    private bool isView = false;

    private void Start()
    {
        input.action.started += UseMenu;
    }
    private void UseMenu(InputAction.CallbackContext obj)
    {
        if(isView == false)
        {
            menu.OnShow();
            isView = true;
        }
        else
        {
            menu.OnHide();
            isView = false;
        }
    }
}
