using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Inimigo : MonoBehaviour
{
    public GameObject Inimigo;

    public float SPAWN_RATE;   

    private float NEXT_SPAWN; 
    void Start()
    {
        
    }

    void Update()
    {
         if(Time.time > NEXT_SPAWN)
        {
            NEXT_SPAWN = Time.time + SPAWN_RATE;

            Instantiate(Inimigo, transform.position, Inimigo.transform.rotation);
        }
    }
}
