using UnityEngine;

public class CubeSystem : MonoBehaviour
{
    public void Update()
    {
        transform.Rotate(new Vector3(2f, 2f, 2f) * 10f * Time.deltaTime);
    }
}
