using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private Transform player;
    public float speed = 2f;

    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
            player = playerObj.transform;
    }

    void Update()
    {
        if (player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position += (Vector3)direction * speed * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DiePlayer(collision.gameObject); 
            Die(); 
        }
    }

    
    void Die()
    {
        Enemy enemyScript = GetComponent<Enemy>(); 
        if (enemyScript != null)
        {
            enemyScript.Die(); 
        }
    }
    void DiePlayer(GameObject player)
    {
        Destroy(player); 
    }
}
