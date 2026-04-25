using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public int ammoAmount = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        PlayerController player = other.GetComponent<PlayerController>();

        if (player != null)
        {
            player.SendMessage("AddAmmo", ammoAmount, SendMessageOptions.DontRequireReceiver);

            Destroy(gameObject); // 👈 només aquest pickup desapareix
        }
    }
}