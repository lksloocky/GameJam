using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SProjetil : MonoBehaviour
{
    public Collider2D PROJ;

    public float LifeTime;

    public float tiro_velo;
    void Start()
    {
         //destroir
        Destroy(gameObject, LifeTime);
    }


    void Update()
    {
         //movimento
        transform.Translate(Vector2.right * tiro_velo * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<InimigoScript>(out InimigoScript triangleComponent))
        {
            triangleComponent.TakeDamage(1);
        }
        Destroy(gameObject);
    }
}
