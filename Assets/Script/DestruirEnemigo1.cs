using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirEnemigo1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jugador")
        {
            Destroy(transform.parent.gameObject);
            //Destroy(gameObject);
        }
    }
}
