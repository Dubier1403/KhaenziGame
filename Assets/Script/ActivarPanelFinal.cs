using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPanelFinal : MonoBehaviour
{
    public GameObject panel;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Jugador")
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
