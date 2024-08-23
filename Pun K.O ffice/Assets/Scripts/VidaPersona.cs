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
public TMP_Text HP;
public string hpcount;
 public SpriteRenderer corzinha;

    void Start()
    {
      ContaKill.Kills = 0;
      //atribui a vida maxima, podemos mudar dps
        hp = MAXHP;
    }


void Update()
{
  //contador de vida na interface
      hpcount = Convert.ToString(hp);
      HP.text = hpcount;

  //condicao de morte para levar ao fim do jogo
  if(hp == 0)
  {
    SceneManager.LoadScene("GameOver");
  }
}

















     public void TomaDano(int damage_amout_p)
   {
    //reconhece o dano e chama a corotina de efeito
    hp -= damage_amout_p;

    StartCoroutine(Hit());
   }

   private IEnumerator Hit()
   {
    //gera o efeito de dano vermelho, funciona com sprites tbm
    corzinha.color = Color.red;

    yield return new WaitForSeconds(0.1f);
    
    corzinha.color = Color.white;
   }
}
