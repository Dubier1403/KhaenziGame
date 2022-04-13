using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public static ControladorJugador Instance;

    // Mecánica Movimiento
    public float VelocidadMovimiento;
    private float direccion;

    // Componentes
    private Rigidbody2D rigbody;

    // Mecánica Salto
    public float FuerzaSalto;

    // Giro
    private bool MoviendoIzquierda = false;

    // Detectar piso
    public Transform CheckGround;
    public LayerMask Ground;
    private bool TocandoSuelo;

    // Doble Salto
    private bool DobleSalto;

    // Animación
    private Animator animacion;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        rigbody = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
    }

    public void Update()
    {
        direccion = Input.GetAxisRaw("Horizontal");

        if (direccion > 0 && MoviendoIzquierda)
        {
            Flip();
            MoviendoIzquierda=false;
        } else if (direccion < 0 && !MoviendoIzquierda)
        {
            Flip();
            MoviendoIzquierda=true;
        }

        TocandoSuelo = Physics2D.OverlapCircle(CheckGround.position, .2f, Ground);

        if (TocandoSuelo)
        {
            DobleSalto = true;
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (TocandoSuelo)
            {
                rigbody.AddForce(Vector2.up * FuerzaSalto, ForceMode2D.Impulse);
            }
            else
            {
                if (DobleSalto)
                {
                    rigbody.AddForce(Vector2.up * FuerzaSalto, ForceMode2D.Impulse);
                    DobleSalto=false;
                }
            }
        }

        // animación 
        animacion.SetFloat("VelocidadMov", Mathf.Abs(rigbody.velocity.x));
    }

    private void FixedUpdate()
    {
        rigbody.velocity = new Vector2(direccion * VelocidadMovimiento, rigbody.velocity.y);    
    }

    private void Flip()
    {
        Vector2 Scale = transform.localScale;
        Scale.x = Scale.x * -1;
        transform.localScale = Scale;
    }

   
}
