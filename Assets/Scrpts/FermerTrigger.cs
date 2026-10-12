using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class FermerTrigger : MonoBehaviour
{
    [SerializeField] private InputActionProperty input;
    [SerializeField] private GameObject hintText;

    private bool isTrigger = false;

    public Action isTalk;
    public Action isExit;

    private void Start()
    {
        input.action.started += TalkFermer;
    }
    private void TalkFermer(InputAction.CallbackContext obj)
    {
        if(isTrigger != false)
        {
            hintText.GetComponent<TextView>().OnHide();
            isTalk?.Invoke();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Player"))
       {
            hintText.SetActive(true);
            isTrigger = true;
            hintText.GetComponent<TextView>().OnShow();
       }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isExit?.Invoke();
            isTrigger = false;
            hintText.GetComponent<TextView>().OnHide();
        }
    }

}
