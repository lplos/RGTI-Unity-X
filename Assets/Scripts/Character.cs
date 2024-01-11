using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private CharacterController characterController;
    public float Speed = 5f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        //transform.rotation = Mathf.Atan2(0, 0) * Mathf.Rad2Deg + 180;
    }

    // Update is called once per frame
    /*void Update()
    {
        float hori = Input.GetAxisRaw("Horizontal");   //levo - desno
        float verti = Input.GetAxisRaw("Vertical");
        Vector3 move = new Vector3(hori, 0, verti).normalized;

        if(move.magnitude >= 0.1f){
            float targetAngle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg + 180;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            
            characterController.Move(move * Time.deltaTime * Speed);
        }
    }*/

    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;

    void Update()
    {
        // Movement input
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Move forward or backward
        transform.Translate(-Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);

        // Rotate left or right
        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
