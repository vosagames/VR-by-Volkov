using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Pistol : MonoBehaviour
{
    [SerializeField] private Transform firePosition;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float bulletForce;
    [SerializeField] private List<AudioSource> bamList = new List<AudioSource>();

    public void OnFire()
    {
        GameObject temp_bullet = Instantiate(bullet, firePosition.position, Quaternion.identity);
        temp_bullet.GetComponent<Rigidbody>().AddForce(firePosition.forward * bulletForce, ForceMode.Impulse);
        GameObject temp = Instantiate(bamList[Random.Range(0, bamList.Count)].gameObject);
        temp.GetComponent<AudioSource>().Play();
        Destroy(temp, 1f);
        Destroy(temp_bullet, 4f);
    }
    
}
