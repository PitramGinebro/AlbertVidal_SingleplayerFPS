using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healAmount = 25;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        PlayerController player = other.GetComponent<PlayerController>();

        if (player != null)
        {
            // "curar" = damage negatiu
            player.SendMessage("Damage", -healAmount, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }
}