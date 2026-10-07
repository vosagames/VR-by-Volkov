using UnityEngine;

public class Potato : MonoBehaviour
{
   private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void OnDrop()
    {
        rb.isKinematic = false;
    }
}
