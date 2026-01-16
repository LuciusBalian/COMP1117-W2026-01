using UnityEditor.UI;
using UnityEngine;

public class CherryPickUpScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        PlayerController thePlayerController = GameObject.FindFirstObjectByType<PlayerController>();

        thePlayerController.IncreaseMoveSpeed(5);
        gameObject.SetActive(false);
    }
}
