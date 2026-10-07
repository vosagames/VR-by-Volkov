using UnityEngine;
using System.Collections;

public class Case : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Morkovka>() ||  other.GetComponent<Potato>())
        {
            StartCoroutine(DropToCase(other));
        }
    }
    private IEnumerator DropToCase(Collider collider)
    {
        yield return new WaitForSeconds(1f);
        collider.GetComponent<Rigidbody>().isKinematic = true;
    }
}
