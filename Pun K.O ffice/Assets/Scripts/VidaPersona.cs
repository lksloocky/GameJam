using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPersona : MonoBehaviour
{

private int MAXHP = 3;
private int hp;
 public SpriteRenderer corzinha;

    void Start()
    {
        hp = MAXHP;
    }


    void Update()
    {
        
    }

     public void TomaDano(int damage_amout_p)
   {
    hp -= damage_amout_p;

    StartCoroutine(Hit());

   }

   private IEnumerator Hit()
   {
    corzinha.color = Color.red;

    yield return new WaitForSeconds(0.1f);
    
    corzinha.color = Color.white;
   }
}
