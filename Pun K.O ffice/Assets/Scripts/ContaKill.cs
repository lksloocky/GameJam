using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public static class ContaKill
{

private static int kills;


public static int Kills
{
    get{return kills;}
    set{
        kills = value;
        if(kills < 0)
        {
            kills = 0;
        }
        Debug.Log(Kills);
    }

}

}
