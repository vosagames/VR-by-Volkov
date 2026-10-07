using UnityEngine;

public class Tapka : MonoBehaviour
{
    [SerializeField] float forcePunch = 1.5f;
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
            if(collision.gameObject.GetComponent<Gradka>() && rb.linearVelocity.magnitude > forcePunch)
            {
                collision.gameObject.GetComponent<Gradka>().OnKopat();
            }
        }
    }
    public void OnPut() => isPut = true;
    public void OnDrop() => isPut = false;

}
