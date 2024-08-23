using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
  private Transform posisaoJogador;
    public float velocidadeInimigo;
    private int Health, MAXHP = 30;

    public float knockbackPower = 100;
    public float knockbackDuration = 1;

    void Start()
    {
        Health = MAXHP;

        posisaoJogador = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {
         SegueJogador();
    }

    private void SegueJogador()
    {
        transform.position = Vector2.MoveTowards(transform.position, posisaoJogador.position, velocidadeInimigo * Time.deltaTime);
    }

    public void TakeDamage(int damage_amout)
   {
    Health -= damage_amout;

    if(Health<=0)
    {
        Destroy(gameObject);
    }
   }

   private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<VidaPersona>(out VidaPersona cubeComponent))
        {
            cubeComponent.TomaDano(1);
//Chama a rotina para knockback
            StartCoroutine(TopdownMovement.instance.Knockback(knockbackDuration, knockbackPower, this.transform));
            Debug.Log("1");
        }
        
    }
    
}
