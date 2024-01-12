using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        //transform.rotation = Mathf.Atan2(0, 0) * Mathf.Rad2Deg + 180;
    }

    public float moveSpeed = 5f;
    public float rotationSpeed = 180f;

    void Update()
    {
        // Movement input
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Move forward or backward
        //transform.Translate(-Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
        Vector3 moveDirection = -transform.forward * verticalInput * moveSpeed;
        characterController.Move(moveDirection * Time.deltaTime);

        // Rotate left or right
        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);

        // Stop movement when no input is provided
        /*if (Mathf.Approximately(verticalInput, 0f) && Mathf.Approximately(horizontalInput, 0f))
        {
            characterController.SimpleMove(Vector3.zero);
        }*/
    }
}
