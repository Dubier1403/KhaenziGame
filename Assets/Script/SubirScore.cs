using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubirScore : MonoBehaviour
{
    public static SubirScore instance;

    private void Awake()
    {
        instance = this;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Vida")
        {
            ControladorVidas.instance.SubirVida();
            Destroy(other.gameObject);
        }
    }
}
