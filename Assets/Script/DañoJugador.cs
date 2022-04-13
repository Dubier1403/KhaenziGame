using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoJugador : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "PlantasVenenosa" || other.gameObject.tag == "Spikes")
        {
            //Debug.Log("Hit");
            ControladorVidas.instance.daño();
        }
        if (other.gameObject.tag == "Niebla")
        {
            ControladorVidas.instance.MuerteInmediata();
        }
    }
}
