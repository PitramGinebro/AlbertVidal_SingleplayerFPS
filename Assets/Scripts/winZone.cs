using UnityEngine;

public class WinZone : MonoBehaviour
{
    public GameObject winUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Win();
        }
    }

    void Win()
    {
        winUI.SetActive(true);
        Time.timeScale = 0f;
    }
}