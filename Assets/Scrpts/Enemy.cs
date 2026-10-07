using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent agent;
    private float hp = 5f;
    public Transform target;
    public AudioSource voice;

    private void Start()
    {
        voice.Play();
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.SetDestination(target.position);

        if (Vector3.Distance(agent.transform.position, target.position) < 1f)
        { 
            {
                Debug.Log("Убиваю");
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            hp -= 1f;
            if(hp <= 0f)
            {
                Destroy(gameObject);
            }
        }
    }

}
