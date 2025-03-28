using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int killsRequired = 4; 
    public GameObject bossPrefab; 
    private int kills = 0; 

    void Start()
    {
        
    }

   
    public void RegisterKill()
    {
        kills++; 
        Debug.Log("Kills: " + kills);

        if (kills >= killsRequired) 
        {
            SpawnBoss();
            Debug.Log("Spawn boss");
        }
    }

    void SpawnBoss()
    {
        if (bossPrefab != null)
        {
            Vector3 spawnPosition = new Vector3(0f, 0f, 0f); 
            Instantiate(bossPrefab, spawnPosition, Quaternion.identity);
            Debug.Log("Boss has spawned!");
        }
        else
        {
            Debug.LogWarning("Boss Prefab is not assigned!");
        }
    }

}
