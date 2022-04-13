using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelNoNillus : MonoBehaviour
{
    public void Reiniciar()
    {
        SceneManager.LoadScene("MainLevel");
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
