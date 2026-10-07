using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float forcePunch;
    private Rigidbody rb;
    private bool isPut = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(isPut == true)
        {
            if (collision.gameObject.CompareTag("Block") && rb.linearVelocity.magnitude > forcePunch) 
            {
                Debug.Log("DAMAGE!");
            }
        }
    }

    public void OnPut() => isPut = true;
    public void OnDrop() => isPut = false;
}
