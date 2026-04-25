using UnityEngine;

public class PauseToggle : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;

            if (isPaused)
                Time.timeScale = 0f; // pausa
            else
                Time.timeScale = 1f; // continuar
        }
    }
}