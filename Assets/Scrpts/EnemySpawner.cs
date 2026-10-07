using UnityEngine;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private List<GameObject> enemy = new List<GameObject>();
    private int count = 0;

    public void SpawnEnemy()
    {
        count += 5;
        for(int i = 0; i < count; i++)
        {
            GameObject _enemy = Instantiate(enemy[Random.Range(0,3)], transform.position, Quaternion.identity);
            _enemy.GetComponent<Enemy>().target = player;
        }
    }
}
