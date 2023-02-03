using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public void AAAEscena(string elLugar)
    {
        SceneManager.LoadScene(elLugar);
    }
    public void AAASalir()
    {
        Application.Quit();
    }
}
