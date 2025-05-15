using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 8f;
    public float gravity = -20f;
    CharacterController characterController;
    Vector3 inputVector;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        GetInput();
        Move();
    }

    void GetInput()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
    }

    void Move()
    {
        Vector3 moveVector = transform.TransformDirection(inputVector.normalized);
        moveVector *= moveSpeed;
        moveVector.y = gravity;
        moveVector *= Time.deltaTime;
        characterController.Move(moveVector);
    }
}