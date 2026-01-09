using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rBody;
    public float speed = 5.0f;
    PlayerStats stats;

    Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();

        
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        ApplyMovement();
        PlayerStats stats = new PlayerStats();

        stats.MoveSpeed = 100;
    }

    void ApplyMovement()
    {
        float targetVelocityX = moveInput.x;

        rBody.linearVelocity = new Vector2(targetVelocityX, rBody.linearVelocity.y);
    }
}
