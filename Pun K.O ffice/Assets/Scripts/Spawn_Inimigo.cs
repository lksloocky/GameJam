using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Inimigo : MonoBehaviour
{
    public GameObject Inimigo;

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
    }

    private void SpawnEnemy()
    {
        Vector3 position = new Vector3
        (
            UnityEngine.Random.Range(-spawnArea.x, spawnArea.x),
            UnityEngine.Random.Range(-spawnArea.y, spawnArea.y),
            0f
        );

        GameObject newEnemy = Instantiate(Inimigo);
        newEnemy.transform.position = position;
    }

}
