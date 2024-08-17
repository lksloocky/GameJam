using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaScript : MonoBehaviour
{
    public Transform Barrel;  //posisao da arma
    public float FireRate;    //cadencia
    public GameObject Bullet;   //projetil

    public float FireTimer;    //controle de cadencia
    
    void Update()
    {
        ControleDeTiro();
    }

    private void  ControleDeTiro()
    {
        if(Input.GetMouseButtonDown(0) && CanShoot()) //verifica se o botao esta precionado e a funcao CanShoot
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        FireTimer = Time.time + FireRate;

        //instancia o prefab da bala para ser chamado
        Instantiate(Bullet, Barrel.position, Barrel.rotation);
    }

    private bool CanShoot()
    {
        return Time.time > FireTimer;
    }
}
