using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mira_Arma : MonoBehaviour
{
    public Transform player;
    public float offset;

    void Update()
    {
        HandleAiming();
    }

    private void HandleAiming()
    {
            // rotacao
            var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, 0, angle);

            //posicao
            Vector3 playerToMoudeDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - player.position;
            playerToMoudeDir.z = 0;
            transform.position = player.position + (offset * playerToMoudeDir.normalized);

            //girar
            Vector3 localScale = Vector3.one;

            if(angle > 90  || angle < -90)
            {
                localScale.y = -1f;
            }
            else
            {
                localScale.y = 1f;
            }
            transform.localScale = localScale;

    }
}
