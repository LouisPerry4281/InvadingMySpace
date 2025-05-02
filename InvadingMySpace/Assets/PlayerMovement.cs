using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    PlayerInputManager input;

    [SerializeField] float movementSpeed = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        input = PlayerInputManager.instance;
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        Vector2 movement = input.GetInputDirection() * movementSpeed * Time.deltaTime;
        rb.linearVelocity = movement;
    }
}
