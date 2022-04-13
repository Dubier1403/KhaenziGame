using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ControlVidaEnemigo : MonoBehaviour
{
    private int vidas = 2;
    private Animator anm;

    private void Start()
    {
        anm = GetComponent<Animator>();
    }

    void Update()
    {
        anm.Play("LateralEnemigo");
    }

    public void CheckVida()
    {
        if (vidas == 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Disparo")
        {
            //Debug.Log("Hit");
            vidas--;
            CheckVida();
        }
    }
}
