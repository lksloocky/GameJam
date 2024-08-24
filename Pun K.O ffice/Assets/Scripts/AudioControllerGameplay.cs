using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllerGameplay : MonoBehaviour
{
    public AudioSource audioSourceMusicaDeFundo;
    public AudioSource audioSourceMusicaDeFundo2;
    public AudioSource audioSourceMusicaDeFundo3;
    
    public AudioClip musicaDeFundo;
    public AudioClip musicaDeFundo2;
    public AudioClip musicaDeFundo3;
    void Start()
    {
        audioSourceMusicaDeFundo.clip = musicaDeFundo;
        audioSourceMusicaDeFundo.loop = true;
        audioSourceMusicaDeFundo.mute = true;
        audioSourceMusicaDeFundo.Play();   

        audioSourceMusicaDeFundo2.clip = musicaDeFundo2;
        audioSourceMusicaDeFundo2.loop = true;
        audioSourceMusicaDeFundo2.mute = true;
        audioSourceMusicaDeFundo2.Play();  

        audioSourceMusicaDeFundo3.clip = musicaDeFundo3;
        audioSourceMusicaDeFundo3.loop = true;
        audioSourceMusicaDeFundo3.Play();   
  
    }

private void Update()
{
        if(ContaKill.Kills == 20)
        {
          audioSourceMusicaDeFundo.mute = false;
          audioSourceMusicaDeFundo2.mute = false;
          audioSourceMusicaDeFundo3.mute = true;        
        }
}
}
