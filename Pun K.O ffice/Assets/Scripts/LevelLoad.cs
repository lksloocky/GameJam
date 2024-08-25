using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    public Animator trasition;

    public void Transition(string SceneName)
    {
    StartCoroutine(LoadScene(SceneName));
    }

    IEnumerator LoadScene(string SceneName)
    {
        trasition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneName);
    }

}
