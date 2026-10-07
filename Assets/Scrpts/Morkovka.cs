using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Morkovka : MonoBehaviour
{
    private Rigidbody rb;
    private XRGrabInteractable interactable;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        interactable = GetComponent<XRGrabInteractable>();
    }
    public void IsDrop()
    {
        rb.isKinematic = false;
        interactable.movementType = XRBaseInteractable.MovementType.VelocityTracking;
    }
}
