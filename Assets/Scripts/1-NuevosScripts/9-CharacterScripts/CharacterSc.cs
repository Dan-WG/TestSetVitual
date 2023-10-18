using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterSc : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 2.0f;

    private void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float mouseXInput = Input.GetAxis("Mouse X");
        float mouseYInput = Input.GetAxis("Mouse Y");

        // Calculate movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput);

        // Normalize the direction to prevent faster movement diagonally
        moveDirection.Normalize();

        // Calculate the desired movement amount
        Vector3 movement = moveDirection * moveSpeed * Time.deltaTime;

        // Move the character
        transform.Translate(movement);

        // Rotate the character based on mouse input around local X and Y axes
        transform.Rotate(Vector3.up * mouseXInput * rotationSpeed);
        transform.Rotate(Vector3.left * mouseYInput * rotationSpeed);
    }
}


