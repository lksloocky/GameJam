using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

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
  if(hp == 0)
  {
    SceneManager.LoadScene("GameOver");
  }
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
