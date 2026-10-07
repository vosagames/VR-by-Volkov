using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractInput : MonoBehaviour
{
    [SerializeField] private InputActionProperty actionProperty;

    private void Start()
    {
        actionProperty.action.performed += RayInteract;
    }
    private void RayInteract(InputAction.CallbackContext obj)
    {
        Debug.Log("321");
        Ray ray = new Ray(transform.position, transform.forward);   
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider != null)
            {
                Debug.DrawRay(transform.position, transform.forward, Color.blue);
                Debug.Log("i'am cast");
            }
        }
    }
}
