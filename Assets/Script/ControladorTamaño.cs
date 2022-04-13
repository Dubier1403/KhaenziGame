using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTamaño : MonoBehaviour
{
    private Vector2 NewSize;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        NewSize = transform.localScale;
        if (collision.gameObject.tag == "PocionDisminuye")
        {
            NewSize.x *= .5f;
            NewSize.y *= .5f;
            transform.localScale = NewSize;
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.tag == "PocionAumento")
        {
            NewSize.x *= 2;
            NewSize.y *= 2;
            transform.localScale = NewSize;
            Destroy(collision.gameObject);
        }
    }
}
