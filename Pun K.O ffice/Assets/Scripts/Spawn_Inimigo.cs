using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Inimigo : MonoBehaviour
{
    public GameObject Inimigo;
    public GameObject player;

    public GameObject Boss;

    public Vector2 spawnArea;
    public float SPAWN_RATE;   

    float timer;
    

    void Update()
    {
        timer -= Time.deltaTime;
         if(timer < 0f)
        {
           SpawnEnemy();
           timer = SPAWN_RATE;
        }

        if(ContaKill.Kills == 30)
        {
            SpawnBoss();
            SPAWN_RATE = SPAWN_RATE - 0.65f;
        }
    }

    private void SpawnEnemy()
    {
        Vector3 position = GenerateRandomPosition();

        position += player.transform.position;

        GameObject newEnemy = Instantiate(Inimigo);
        newEnemy.transform.position = position;
    }

    private Vector3 GenerateRandomPosition()
    {
        Vector3 position = new Vector3();

        float f = UnityEngine.Random.value > 0.5f ? -1f : 1f;

        if (UnityEngine.Random.value > 0.5f)
        {
            position.x = UnityEngine.Random.Range(-spawnArea.x, spawnArea.x);
            position.y = spawnArea.y * f;
        }
        else{
            position.y = UnityEngine.Random.Range(-spawnArea.y, spawnArea.y);
            position.x = spawnArea.x * f;
        }

        position.z = 0;

        return position;
    }

     private void SpawnBoss()
    {
        ContaKill.Kills++;
        Vector3 position2 = GenerateRandomPosition();

        position2 += player.transform.position;

        GameObject newBoss = Instantiate(Boss);
        newBoss.transform.position = position2;
    }

}
