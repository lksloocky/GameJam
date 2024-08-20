using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KnockBackFeedBack : MonoBehaviour
{
   [SerializeField]
   private Rigidbody2D rb2d;

   [SerializeField]
   private float forca = 16, delay = 0.15f;

   public UnityEvent OnBegin, OnDone;

   public void PlayFeedback (GameObject sender) 
   {
    Debug.Log("2");
      StopAllCoroutines();
      OnBegin?.Invoke();
      Vector2 direction = (transform.position - sender.transform.position).normalized;
      rb2d.AddForce (direction * forca, ForceMode2D.Impulse);
      StartCoroutine(Reset());
   }

   private IEnumerator Reset() 
   {
    yield return new WaitForSeconds(delay);
    rb2d.velocity = Vector3.zero;
    OnDone?.Invoke();
   }
}
