using UnityEngine;
using System.Collections.Generic;

public class Tapka : MonoBehaviour
{
    [SerializeField] float forcePunch = 1.5f;
    [SerializeField] private List<AudioSource> tapkaSound = new List<AudioSource>();
    [SerializeField] private GameObject effect;
    [SerializeField] private Transform effectPos;
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
                tapkaSound[Random.Range(0, tapkaSound.Count)].Play();
                GameObject obj = Instantiate(effect, effectPos.position, Quaternion.identity);
                Destroy(obj, 1.5f);
            }
        }
    }
    public void OnPut() => isPut = true;
    public void OnDrop() => isPut = false;

}
