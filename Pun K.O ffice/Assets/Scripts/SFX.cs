using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
     public AudioSource guitarraSFX;
     public AudioClip nota;

     void Start()
    {
        guitarraSFX.clip = nota;
        guitarraSFX.Play();
    }
}
