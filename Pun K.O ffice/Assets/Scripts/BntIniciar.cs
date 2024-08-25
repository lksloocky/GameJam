using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CanvasMenu : MonoBehaviour
{
  public LevelLoad levelLoad;

   public void LoadScenes(string SceneName)
   {
        levelLoad.Transition(SceneName);
   }

    public void GameExit()
    {
        Application.Quit();
    }

}
