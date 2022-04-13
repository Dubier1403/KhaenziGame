using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RecolectarGemas : MonoBehaviour
{
    public static RecolectarGemas instance;
    public TMP_Text texto;
    public float CantidadGemas;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        CantidadGemas = 0;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Gema")
        {
            CantidadGemas += 5;
            //Debug.Log(CantidadGemas);
            texto.SetText("X " + CantidadGemas);
            Destroy(other.gameObject);
        }

    }
}
