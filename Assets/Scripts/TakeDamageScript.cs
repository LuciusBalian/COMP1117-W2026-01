using UnityEngine;
using UnityEngine.InputSystem;

public class TakeDamageScript : MonoBehaviour
{
    [SerializeField] private PlayerController thePlayerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        thePlayerController.TakeDamage(10);
        print("Sent dmg");
    }
}
