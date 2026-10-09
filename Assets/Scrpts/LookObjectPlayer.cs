using UnityEngine;

public class LookObjectPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    private void Update()
    {
        transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));
    }
}
