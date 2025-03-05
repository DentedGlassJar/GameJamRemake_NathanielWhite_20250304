using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using static InputManager;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;

    public Vector2 moveDirection;
    private float moveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = this.GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        Actions.moveEvent += UpdateVector;
    }

    private void OnDisable()
    {
        Actions.moveEvent -= UpdateVector;
    }

    void HandlePlayerMovement()
    {
        playerRigidbody.MovePosition(playerRigidbody.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }

    // if the MoveEvent is enabled, it updates the moveVector value with the inputVector value
    void UpdateVector(Vector2 inputVector)
    {
        moveDirection = inputVector;
    }

    private void FixedUpdate()
    {
        HandlePlayerMovement();
    }
}
