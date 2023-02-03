using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public static bool isGamePaused;
    private GameObject PauseMenuCanvas;
    private void Awake()
    {
        PauseMenuCanvas = GameObject.FindGameObjectWithTag("MenuPausa");
        PauseMenuCanvas.SetActive(false);
    }

    public void PauseGame()
    {
        if (isGamePaused)
        {
            Time.timeScale = 0f;
            PauseMenuCanvas.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;

            PauseMenuCanvas.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isGamePaused = !isGamePaused;
            PauseGame();
        }
    }
}
