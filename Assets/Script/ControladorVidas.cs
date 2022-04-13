using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ControladorVidas : MonoBehaviour
{
    public static ControladorVidas instance;
    public Image BarraVida;

    float ActualV;
    float MaxVida = 100;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        ActualV = MaxVida;
    }

    void Update()
    {
        BarraVida.fillAmount = ActualV / MaxVida;
    }

    public void daño()
    {
        ActualV -= 10;
        if (ActualV == 0)
        {
            SceneManager.LoadScene("MainLevel");
        }
    }

    public void MuerteInmediata()
    {
        ActualV = 0f;
        SceneManager.LoadScene("MainLevel");
    }

    public void SubirVida()
    {
        ActualV += 10;
    }
}
