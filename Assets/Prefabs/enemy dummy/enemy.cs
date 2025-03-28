using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 1;
        public EnemyManager enemyManager;

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
        enemyManager.RegisterKill();
        Destroy(gameObject);
    }
}
