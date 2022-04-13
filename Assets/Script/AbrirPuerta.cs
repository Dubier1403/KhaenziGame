using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    public static AbrirPuerta instance;
    public GameObject puerta;
    public GameObject panel;

    private void Awake()
    {
        instance = this;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jugador")
        {
            if (RecolectarGemas.instance.CantidadGemas > 0)
            {
                Destroy(puerta);
            }
            else
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
