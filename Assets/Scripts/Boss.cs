using UnityEngine;

public class Boss : MonoBehaviour
{
    public int health = 1;
    public EnemyManager enemyManager;
    public GameObject bulletPrefab;
    public Transform shootingPoint;
    public float shootRate = 1f;
    private float shootTimer = 0f;

    public void TakeDamage()
    {
        health--;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        shootTimer += Time.deltaTime;

        if (shootTimer >= 1f / shootRate)
        {
            Shoot();
            shootTimer = 0f;
        }
    }

    void Shoot()
    {
        if (bulletPrefab != null && shootingPoint != null)
        {
            Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity);
        }
    }
}
