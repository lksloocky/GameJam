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

    private Rigidbody2D rb2d;
    private Animator animator;

    void Start()
    {
        Health = MAXHP;

        posisaoJogador = GameObject.FindGameObjectWithTag("Player").transform;
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        SegueJogador();
        AtualizaAnimator();
    }

    private void SegueJogador()
    {
        Vector2 direction = (posisaoJogador.position - transform.position).normalized;
        rb2d.velocity = direction * velocidadeInimigo;
    }

    private void AtualizaAnimator()
    {
        Vector2 moveDirection = rb2d.velocity.normalized;
        animator.SetFloat("Horizontal", moveDirection.x);
        animator.SetFloat("Vertical", moveDirection.y);
        animator.SetFloat("Speed", rb2d.velocity.sqrMagnitude);
    }

    public void TakeDamage(int damage_amout)
    {
        Health -= damage_amout;
        Debug.Log(Health);
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<VidaPersona>(out VidaPersona cubeComponent))
        {
            cubeComponent.TomaDano(1);

            // Chama a rotina para knockback
            StartCoroutine(TopdownMovement.instance.Knockback(knockbackDuration, knockbackPower, this.transform));
            Debug.Log("1");
        }
    }
}
