using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    public GameObject Pause;
    public void ClickEnPanel()
    {
        Time.timeScale = 0;
        Pause.SetActive(true);
    }

    public void ClickReanudar()
    {
        Time.timeScale = 1;
        Pause.SetActive(false);
    }

    public void ClickMenuPrincipal()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuPrincipal");
        Pause.SetActive(false);
    }
}
