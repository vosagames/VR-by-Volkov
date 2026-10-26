using UnityEngine;

public class EffectWater : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision != null)
        {
            Debug.Log(collision);
        }
    }
}
