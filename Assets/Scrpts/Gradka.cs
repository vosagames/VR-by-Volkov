using UnityEngine;

public class Gradka : MonoBehaviour
{
    [SerializeField] private GameObject potato;
    [SerializeField] private Transform potatoSpawnPos;
    private int hp = 3;
   public void OnKopat()
   {
        hp--;
        transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        if(hp <= 0)
        {
            for(int i = 0; i < Random.Range(1, 3); i++)
            {
                Instantiate(potato, potatoSpawnPos.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
   }
}
