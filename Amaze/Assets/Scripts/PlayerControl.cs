using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 8f;
    public float gravity = -20f;
    CharacterController characterController;
    Vector3 inputVector;


    [Header("Looking")]
    public Transform lookCamera;
    public float sensitivityX = 15f;
    public float sensitivityY = 15f;

    public float minY = -90;
    public float maxY = 90;

    float currentYRotation;
    Vector2 aimVector;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }
        
    void Update()
    {
        GetInput();
        Move();
        Look();
    }

    void GetInput()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
        aimVector.x = Input.GetAxis("Mouse X");
        aimVector.y = Input.GetAxis("Mouse Y");
    }

    void Move()
    {
        Vector3 moveVector = transform.TransformDirection(inputVector.normalized);
        moveVector *= moveSpeed;
        moveVector.y = gravity;
        moveVector *= Time.deltaTime;
        characterController.Move(moveVector);
    }

    void Look()
    {
        transform.Rotate(transform.up, aimVector.x * sensitivityX);
        currentYRotation += aimVector.y * sensitivityY;
        currentYRotation = Mathf.Clamp(currentYRotation, minY, maxY);
        lookCamera.eulerAngles = new Vector3(-currentYRotation, lookCamera.eulerAngles.y, lookCamera.eulerAngles.z);
    }
}