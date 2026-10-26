using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] private ParticleSystem waterEffect;
    [SerializeField] private Transform rayCheker;
    private void Update()
    {
        float info = Vector3.Angle(transform.up, Vector3.up);
        if(info > 70f)
        {
            waterEffect.Play();
            Ray ray = new Ray(rayCheker.position, Vector3.down);
            Debug.DrawRay(rayCheker.position, Vector3.down, Color.red);
        }
        else
        {
            waterEffect.Stop();
        }

    }
}
