using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickController : MonoBehaviour
{
    public GameObject instructionPanel;
    public GameObject CreditPanel;

    public void ClickJugar()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void ClickInstruction()
    {
        instructionPanel.SetActive(true);
    }

    public void ClickCredit()
    {
        CreditPanel.SetActive(true);
    }

    public void Cerrar()
    {
        CreditPanel.SetActive(false);
        instructionPanel.SetActive(false);
    }
}
