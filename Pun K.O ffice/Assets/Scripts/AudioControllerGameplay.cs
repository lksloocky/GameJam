using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllerGameplay : MonoBehaviour
{
    public AudioSource audioSourceMusicaDeFundo;
    public AudioSource audioSourceMusicaDeFundo2;
    
    public AudioClip musicaDeFundo;
    public AudioClip musicaDeFundo2;
    void Start()
    {
        audioSourceMusicaDeFundo.clip = musicaDeFundo;
        audioSourceMusicaDeFundo.loop = true;
        audioSourceMusicaDeFundo.Play();     
    }

    private void Update()
    {
        if(ContaKill.Kills == 20)
        {
        audioSourceMusicaDeFundo2.clip = musicaDeFundo2;
        audioSourceMusicaDeFundo2.loop = true;
        audioSourceMusicaDeFundo2.Play();     
        }
    }
}
