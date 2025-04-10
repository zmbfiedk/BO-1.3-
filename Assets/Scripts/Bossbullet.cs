using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public float lifetime = 2f;
    public float speed = 5f;
    private Transform player;

    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            player = playerObj.transform;
        }
        Destroy(gameObject, lifetime);
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
            Debug.Log("Player hit by bullet!");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
