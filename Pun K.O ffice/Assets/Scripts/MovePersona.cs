using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class MovePersona : MonoBehaviour
{

    public float speed = 3f;
    public Rigidbody2D RB2;
    public Vector2 direcao;


       void Start()
    {


        RB2 = GetComponent<Rigidbody2D>();


    }

      void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        direcao = new Vector2(horizontal,vertical);

    }

     void FixedUpdate()
    {
        Vector3 posisao = (speed * Time.fixedDeltaTime * direcao.normalized) + RB2.position;

        RB2.MovePosition(posisao);

    }
}
