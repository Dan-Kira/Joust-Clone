using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject Enemy;

    public int EnemyQuant = 0;
    public int MaxEnemyQuant = 6;
    public float spawnInterval = 1f;
    private float LastEnemySpawnTime;

    void Update()
    {
        if(EnemyQuant < MaxEnemyQuant && Time.time > LastEnemySpawnTime + spawnInterval)
        {
            EnemySpawner();
        }
    }

    private void EnemySpawner()
    {
        
        int RandomNumber = Random.Range(0, SpawnPoints.Length);

        GameObject newEnemy = Instantiate(Enemy, SpawnPoints[RandomNumber].position, Quaternion.identity);
        
        EnemyQuant++;
        LastEnemySpawnTime = Time.time;

    }
}
